using ERP_ventas.Datos;
using ERP_ventas.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_ventas.Datos
{
    class ClienteDAO
    {
        public List<Cliente> ConsultaGeneral(string sql_where, List<string> parametros, List<object> valores)
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    string cadena_sql = "select * from Clientes " + sql_where;
                    //idCliente	direccion	codidoPostal	rfc	telefono	email	tipo	estatus     idCiudad

                    SqlCommand comando = new SqlCommand(cadena_sql, conexion);

                    conexion.Open();
                    for (int i = 0; i < parametros.Count; i++)
                    {
                        comando.Parameters.AddWithValue(parametros[i], valores[i]);
                    }

                    SqlDataReader lector = comando.ExecuteReader();
                    if (lector.HasRows)
                    {
                        while (lector.Read())
                        {
                            Cliente cliente = new Cliente(
                                 (int)lector["idCliente"],
                                 (string)lector["direccion"],
                                 (string)lector["codidoPostal"],
                                 (string)lector["rfc"],
                                 (string)lector["telefono"],
                                 (string)lector["email"],
                                 ((string)lector["tipo"])[0], //Se castea primero como string y después se toma el Char en la Pos 0
                                 ((string)lector["estatus"])[0], //Se castea primero como string y después se toma el Char en la Pos 0
                                 (int)lector["idCiudad"]
                                 );
                            clientes.Add(cliente);
                        }
                        lector.Close();
                        conexion.Close();
                    }
                    else
                    {
                        lector.Close();
                        conexion.Close();
                    }
                }
                foreach (Cliente cliente in clientes)
                {
                    parametros.Clear();
                    valores.Clear();
                    parametros.Add("@id");
                    valores.Add(cliente.ID);
                    if (cliente.Tipo == 'I')
                    {
                        List<ClienteIndividual> clientesind = new ClienteIndividualDAO().ConsultaGeneral(" where idCliente=@id", parametros, valores);
                        if (clientesind.Count == 1)
                        {
                            cliente.InfoCliente = clientesind[0]; //Se asigna la posición 0 porque sólo debe de encontrar un registro en ClientesIndividual
                        }
                    }
                    else
                    {
                        List<ClienteTienda> clientestienda = new ClienteTiendaDAO().ConsultaGeneral(" where idCliente=@id", parametros, valores);
                        if (clientestienda.Count == 1)
                        {
                            cliente.InfoCliente = clientestienda[0];
                        }
                    }
                }

            }
            catch (SqlException ex)
            {
                throw new Exception("Error relacionado con la BD. [ClienteDAO.C] \n Anota este error y contacta al administrador.\n" + ex.Message);
            }
            return clientes;
        }

        internal void Eliminar(int ID)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    string cadena_sql = "update Clientes set estatus= 'I' where idCliente=@id";

                    SqlCommand comando = new SqlCommand(cadena_sql, conexion);
                    comando.Parameters.AddWithValue("@id", ID);
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error relacionado con la BD. [ClienteDAO.E] \n Anota este error y contacta al administrador.\n" + ex.Message);
            }
        }

        public object Registrar(Cliente cte)
        {
            object resultado = new object();
            try
            {
                if (Validar(0, cte))
                {
                    using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                    {
                        string cadena_sql = "insert into Clientes values (@dir, @cp, @rfc, @tel, @email, @tipo, @estatus, @idciudad)";
                        //idCliente	direccion	codidoPostal	rfc	telefono	email	tipo	estatus     idCiudad
                        SqlCommand comando = new SqlCommand(cadena_sql, conexion);
                        comando.Parameters.AddWithValue("@dir", cte.Direccion);
                        comando.Parameters.AddWithValue("@cp", cte.CP);
                        comando.Parameters.AddWithValue("@rfc", cte.RFC);
                        comando.Parameters.AddWithValue("@tel", cte.Telefono);
                        comando.Parameters.AddWithValue("@email", cte.Email);
                        comando.Parameters.AddWithValue("@tipo", cte.Tipo);
                        comando.Parameters.AddWithValue("@estatus", cte.Estatus);
                        comando.Parameters.AddWithValue("@idciudad", cte.IDCiudad);
                        conexion.Open();

                        int cant_registros = (int)comando.ExecuteNonQuery();
                        conexion.Close();
                        if (cant_registros == 1)
                        {
                            cte.ID = getID(cte);

                            if (cte.Tipo == 'T')
                            {
                                resultado = new ClienteTiendaDAO().Registrar((ClienteTienda)cte.InfoCliente, cte.ID);
                                Type resultado_tipo = resultado.GetType();

                                if (resultado_tipo.Equals(typeof(string)))
                                {
                                    Mensajes.Error(resultado.ToString());
                                }
                                else
                                {
                                    resultado = true;
                                }
                            }
                            else
                            {
                                resultado = new ClienteIndividualDAO().Registrar((ClienteIndividual)cte.InfoCliente, cte.ID);
                                Type resultado_tipo = resultado.GetType();

                                if (resultado_tipo.Equals(typeof(string)))
                                {
                                    return resultado;
                                }
                                else
                                {
                                    resultado = true;
                                }
                            }
                        }
                        else
                        {
                            resultado = "Se ha generado un error no especificado";
                        }
                    }
                }
                else
                {
                    resultado = "Error: Ya existe una unidad con datos en común";
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error relacionado con la BD. [ClienteDAO.R] \n Anota este error y contacta al administrador.\n" + ex.Message);
            }
            return resultado;
        }

        public int getID(Cliente cte)
        {
            int id = 0;
            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    string cadena_sql = "select idcliente from Clientes where rfc= @rfc and telefono= @tel and email= @email";
                    SqlCommand comando = new SqlCommand(cadena_sql, conexion);
                    comando.Parameters.AddWithValue("@rfc", cte.RFC);
                    comando.Parameters.AddWithValue("@tel", cte.Telefono);
                    comando.Parameters.AddWithValue("@email", cte.Email);
                    conexion.Open();

                    id = (int)comando.ExecuteScalar();
                    conexion.Close();
                }

            }
            catch (SqlException ex)
            {
                throw new Exception("Error relacionado con la BD. [ClienteDAO.GetID] \n Anota este error y contacta al administrador.\n" + ex.Message);
            }
            return id;
        }
        private bool Validar(int tipo, Cliente cte)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    string cadena_sql = "select idcliente from Clientes where rfc= @rfc or telefono= @tel or email= @email";
                    
                    SqlCommand comando = new SqlCommand(cadena_sql, conexion);
                    comando.Parameters.AddWithValue("@rfc", cte.RFC);
                    comando.Parameters.AddWithValue("@tel", cte.Telefono);
                    comando.Parameters.AddWithValue("@email", cte.Email);
                    if (tipo == 1)
                    {
                        cadena_sql += " and idcliente!=@id";
                        comando.Parameters.AddWithValue("@id", cte.ID);
                    }
                    conexion.Open();

                    SqlDataReader lector = comando.ExecuteReader();
                    if (lector.HasRows)
                        return false;
                    else
                        return true;

                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error relacionado con la BD. [ClienteDAO.V] \n Anota este error y contacta al administrador.\n" + ex.Message);
            }
        }

        public object Editar(Cliente cte)
        {
            object resultado = new object();
            try
            {
                if (Validar(0, cte))
                {
                    using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                    {
                        string cadena_sql = "update Clientes set direccion=@dir,codidoPostal= @cp,rfc= @rfc, telefono=@tel," +
                            " email=@email,tipo= @tipo, estatus=@estatus, idCiudad=@idciudad where idcliente = @idcliente";
                        //idCliente	direccion	codidoPostal	rfc	telefono	email	tipo	estatus     idCiudad
                        SqlCommand comando = new SqlCommand(cadena_sql, conexion);
                        comando.Parameters.AddWithValue("@dir", cte.Direccion);
                        comando.Parameters.AddWithValue("@cp", cte.CP);
                        comando.Parameters.AddWithValue("@rfc", cte.RFC);
                        comando.Parameters.AddWithValue("@tel", cte.Telefono);
                        comando.Parameters.AddWithValue("@email", cte.Email);
                        comando.Parameters.AddWithValue("@tipo", cte.Tipo);
                        comando.Parameters.AddWithValue("@estatus", cte.Estatus);
                        comando.Parameters.AddWithValue("@idciudad", cte.IDCiudad);
                        comando.Parameters.AddWithValue("@idcliente", cte.ID);
                        conexion.Open();

                        int cant_registros = (int)comando.ExecuteNonQuery();
                        conexion.Close();
                        if (cant_registros == 1)
                        {
                            cte.ID = getID(cte);

                            if (cte.Tipo == 'T')
                            {
                                resultado = new ClienteTiendaDAO().Editar((ClienteTienda)cte.InfoCliente, cte.ID);
                                Type resultado_tipo = resultado.GetType();

                                if (resultado_tipo.Equals(typeof(string)))
                                {
                                    Mensajes.Error(resultado.ToString());
                                }
                                else
                                {
                                    resultado = true;
                                }
                            }
                            else
                            {
                                resultado = new ClienteIndividualDAO().Editar((ClienteIndividual)cte.InfoCliente, cte.ID);
                                Type resultado_tipo = resultado.GetType();

                                if (resultado_tipo.Equals(typeof(string)))
                                {
                                    return resultado;
                                }
                                else
                                {
                                    resultado = true;
                                }
                            }
                        }
                        else
                        {
                            resultado = "Se ha generado un error no especificado";
                        }
                    }
                }
                else
                {
                    resultado = "Error: Ya existe una unidad con datos en común";
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error relacionado con la BD. [ClienteDAO.R] \n Anota este error y contacta al administrador.\n" + ex.Message);
            }
            return resultado;
        }

        public List<Ciudad> ConsultaCiudades(string sql_where, List<string> parametros, List<object> valores)
        {
            List<Ciudad> ciudades = new List<Ciudad>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    string cadena_sql = "select * from Ciudades " + sql_where;
                    //idCiudad	Ciudad

                    SqlCommand comando = new SqlCommand(cadena_sql, conexion);

                    conexion.Open();
                    for (int i = 0; i < parametros.Count; i++)
                    {
                        comando.Parameters.AddWithValue(parametros[i], valores[i]);
                    }

                    SqlDataReader lector = comando.ExecuteReader();
                    if (lector.HasRows)
                    {
                        while (lector.Read())
                        {
                            Ciudad cd = new Ciudad(
                                 (int)lector["idCiudad"],
                                 (String)lector["nombre"]
                                 );
                            ciudades.Add(cd);
                        }
                        lector.Close();
                        conexion.Close();
                    }
                    else
                    {
                        lector.Close();
                        conexion.Close();
                    }
                }

            }
            catch (SqlException ex)
            {
                throw new Exception("Error relacionado con la BD. [ClienteIndividualDAO] \n Anota este error y contacta al administrador.\n" + ex.Message);
            }
            return ciudades;
        }
    }
}
