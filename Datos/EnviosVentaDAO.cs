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
    class EnviosVentaDAO : Paginacion
    {
        public EnviosVentaDAO()
        {
            table = "VEnviosVentas";  //Nombre de la tabla o vista
            order_by = "idVenta"; //Nombre de la columna para ordenar los registros
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

        public List<EnviosVentas> ConsultaGeneral(string sql_where, List<string> parametros, List<object> valores)
        {
            List<EnviosVentas> env = new List<EnviosVentas>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    string cadena_sql = "select C.direccion, V.fechaEntregaPlaneada 'Fecha de entrega preevista' from EnviosVentas EV inner join Ventas V on V.idVenta=EV.idVenta" +
                        "inner join Clientes C on V.idCliente=C.idCliente" + sql_where;
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
                            EnviosVentas envi = new EnviosVentas(
                                (int)lector["idEnvio"],
                                (int)lector["idVenta"],
                                (DateTime)lector["fechaEntregaPlaneada"],
                                (DateTime)lector["fechaEntregaReal"]
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

        public void Eliminar(int ID)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    string cadena_sql = "update EnviosVentas set estatus= 'I' where idVenta=@id";

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
