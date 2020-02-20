using ERP_ventas.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_ventas.Datos
{
    class ClienteIndividualDAO
    {

        public List<ClienteIndividual> ConsultaGeneral(string sql_where, List<string> parametros, List<object> valores)
        {
            List<ClienteIndividual> clientesInd = new List<ClienteIndividual>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    string cadena_sql = "select * from ClienteIndividual " + sql_where;
                    //idCliente	nombre	apaterno	amaterno	sexo

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
                            ClienteIndividual cliente = new ClienteIndividual(
                                 (string)lector["nombre"],
                                 (string)lector["apaterno"],
                                 (string)lector["amaterno"],
                                 ((string)lector["sexo"])[0]
                                 );
                            clientesInd.Add(cliente);
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
            return clientesInd;
        }



        public bool Registrar(ClienteIndividual cliente, int ID)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    string cadena_sql = "insert into ClienteIndividual values (@id, @nombre, @ap, @am, @sexo) ";

                    SqlCommand comando = new SqlCommand(cadena_sql, conexion);
                    comando.Parameters.AddWithValue("@id", ID);
                    comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
                    comando.Parameters.AddWithValue("@ap", cliente.Apaterno);
                    comando.Parameters.AddWithValue("@am", cliente.Amaterno);
                    comando.Parameters.AddWithValue("@sexo", cliente.Sexo_char);
                    conexion.Open();
                    int rows = comando.ExecuteNonQuery();
                    if (rows != 0)
                        return true;
                    else
                        return false;
                }

            }
            catch (SqlException ex)
            {
                throw new Exception("Error relacionado con la BD. [ClienteIndividualDAO] \n Anota este error y contacta al administrador.\n" + ex.Message);
            }
        }

        internal object Editar(ClienteIndividual cte, int ID)
        {
            object resultado = new object();
            try
            {
                if (Validar(1, ID, cte))
                {
                    using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                    {
                        string cadena_sql = "update ClienteIndividual set nombre= @nombre, apaterno= @ap, amaterno= @am, sexo=@sexo where idCliente=@id";

                        SqlCommand comando = new SqlCommand(cadena_sql, conexion);
                        comando.Parameters.AddWithValue("@id", ID);
                        comando.Parameters.AddWithValue("@nombre", cte.Nombre);
                        comando.Parameters.AddWithValue("@ap", cte.Apaterno);
                        comando.Parameters.AddWithValue("@am", cte.Amaterno);
                        comando.Parameters.AddWithValue("@sexo", cte.Sexo_char);
                        conexion.Open();

                        int cant_registros = (int)comando.ExecuteNonQuery();
                        conexion.Close();
                        if (cant_registros == 1)
                        {
                            resultado = true;
                        }
                        else
                        {
                            resultado = "Se ha generado un error no especificado";
                        }
                    }
                }
                else
                {
                    resultado = "Error: Ya existe un cliente de tienda con datos en común";
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error relacionado con la BD. [ClienteIndividualDAOs.R] \n Anota este error y contacta al administrador.\n" + ex.Message);
            }
            return resultado;
        }

        private bool Validar(int tipo, int ID, ClienteIndividual cte)
        {
            // tipo 0 -> insert ; 1 -> update

            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    string cadena_sql = "";
                    if (tipo == 0)
                        cadena_sql = "select idcliente from ClienteIndividual where nombre=@nombre and apaterno=@apaterno and amaterno=@amaterno";

                    else
                        cadena_sql = "select idcliente from ClienteIndividual where nombre=@nombre and apaterno=@apaterno and amaterno=@amaterno and idcliente!=@id";

                    SqlCommand comando = new SqlCommand(cadena_sql, conexion);
                    comando.Parameters.AddWithValue("@nombre", cte.Nombre);
                    comando.Parameters.AddWithValue("@apaterno", cte.Apaterno);
                    comando.Parameters.AddWithValue("@amaterno", cte.Amaterno);
                    if (tipo == 1)
                        comando.Parameters.AddWithValue("@id", ID);
                    conexion.Open();

                    SqlDataReader lector = comando.ExecuteReader();

                    if (lector.HasRows)
                    {
                        conexion.Close();
                        return false;
                    }
                    else
                    {
                        conexion.Close();
                        return true;
                    }

                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error relacionado con la BD. [ClienteIndividualDAOs.V] \n Anota este error y contacta al administrador.\n" + ex.Message);
            }
        }
    }
}
