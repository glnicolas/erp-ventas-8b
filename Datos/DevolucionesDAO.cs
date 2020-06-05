using System;
using ERP_ventas.Modelo;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_ventas.Datos
{
    class DevolucionesDAO :Paginacion
    {

        public DevolucionesDAO()
        {
            table = "VDevoluciones";  //Nombre de la tabla o vista
            order_by = "idDevolucion"; //Nombre de la columna para ordenar los registros
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
        public List<Devoluciones> ConsultaGenereal(string sql_where, List<string> parametros, List<object> valores) 
        {
            List<Devoluciones> devoluciones = new List<Devoluciones>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    string cadena_sql = "select * from devoluciones " + sql_where;

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
                            Devoluciones dev = new Devoluciones(
                                (int)lector["idDevolucion"],
                                (DateTime)lector["fecha"],
                                (int)lector["idProductoDetalle"],
                                (int)lector["cantidad"],
                                (float)lector["precioUnitario"],
                                (float)lector["total"],
                                (string)lector["motivo"],
                                (int)lector["idVenta"]);
                        }
                    }
                    lector.Close();
                    conexion.Close();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error relacionado con la BD. [ProductoDAO.C] \n Anota este error y contacta al administrador.\n" + ex.Message);
            }
            return devoluciones;
        }

        //public object Registrar() 
        //{

        //}
    }
}
