using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_ventas.Modelo;
using System.Data.SqlClient;
using System.Data;


namespace ERP_ventas.Datos 
{
    class EnviosDAO : Paginacion
    {
        public EnviosDAO()
        {
            table = "VEnvios";  //Nombre de la tabla o vista
            order_by = "ID"; //Nombre de la columna para ordenar los registros
            rows_per_page = 3;          //Cantidad de registros por página
            try
            {
                CalculatePages(); //Calcula la cantidad de páginas que se deben emplear
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public object Editar(Envios env)
        {
            object resultado = new object();
            try
            {
                    using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                    {
                        string cadena_sql = "update envios set fechasalida=@fs, idUnidadTransporte=@idut where idenvio=@id";

                        SqlCommand comando = new SqlCommand(cadena_sql, conexion);
                        comando.Parameters.AddWithValue("@id", env.idenvio);
                        comando.Parameters.AddWithValue("@fs", env.fechaSalida);
                        comando.Parameters.AddWithValue("@idut", env.idUnidadTransporte);
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
            catch (SqlException ex)
            {
                throw new Exception("Error relacionado con la BD. [ClienteTiendaDAO.R] \n Anota este error y contacta al administrador.\n" + ex.Message);
            }
            return resultado;
        }

        public List<Envios> ConsultaGeneral(string sql_where, List<string> parametros, List<object> valores)
        {
            List<Envios> env = new List<Envios>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    string cadena_sql = "select idEnvio, fechaSalida, idUnidadTransporte,estatus from Envios"+sql_where;
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
                            Envios envi = new Envios(
                                (int)lector["idEnvio"],
                                (DateTime)lector.GetDateTime(1),
                                (int)lector["idUnidadTransporte"],
                                ((string)lector["estatus"])[0]
                                );
                            env.Add(envi);
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
            catch (Exception ex)
            {
                throw new Exception("Error relacionado con la BD. [TripulacionDAO.c] \n Anota este error y contacta al administrador.\n" + ex.Message);
            }
            return env;
        }

        public object Registrar(Envios env)
        {
            object resultado = new object();
            try
            {
                    using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                    {
                        string cadena_sql = "insert into envios values (@fechaSalida, @idUnidadTransporte, @estatus)";

                        SqlCommand comando = new SqlCommand(cadena_sql, conexion);
                        comando.Parameters.AddWithValue("@fechaSalida", env.fechaSalida);
                        comando.Parameters.AddWithValue("@idUnidadTransporte", env.idUnidadTransporte);
                        comando.Parameters.AddWithValue("@estatus", env.estatus);
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
            catch (SqlException ex)
            {
                throw new Exception("Error relacionado con la BD. [ClienteIndividualDAO.R] \n Anota este error y contacta al administrador.\n" + ex.Message);
            }
            return resultado;
        }



        public bool Validar(Envios env)
        {
            // tipo 0 -> insert ; 1 -> update

            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    string cadena_sql = "";
                    cadena_sql = "select idEnvio from envios where idEnvio=@idEnvio";
                    SqlCommand comando = new SqlCommand(cadena_sql, conexion);
                    comando.Parameters.AddWithValue("@idEnvio", env.idenvio);
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
                throw new Exception("Error relacionado con la BD. [ClienteIndividualDAO.V] \n Anota este error y contacta al administrador.\n" + ex.Message);
            }
        }


        public void Eliminar(int ID)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    string cadena_sql = "update Envios set estatus= 'I' where idEnvio=@id";

                    SqlCommand comando = new SqlCommand(cadena_sql, conexion);
                    comando.Parameters.AddWithValue("@id", ID);
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error relacionado con la BD. [ClienteIndividualDAO.E] \n Anota este error y contacta al administrador.\n" + ex.Message);
            }
        }

    }
}
