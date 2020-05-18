using ERP_ventas.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_ventas.Datos
{
    class VentaDAO
    {

        public List<Venta> ConsultaGeneral(string sql_where, List<string> parametros, List<object> valores)
        {
            List<Venta> ventas = new List<Venta>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    string cadena_sql = "select * from ventas " + sql_where;
                    
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
                            Empleado empleado = null;
                            Cliente cliente = null;
                            if (lector["idempleado"] != DBNull.Value)
                            {
                                cliente = new ClienteDAO().ConsultaGeneral(
                                    " where idCliente = @id", new List<string>() {"@id"}, new List<object>() {(int)lector["idCliente"] })[0];
                            }
                            if (lector["idempleado"] != DBNull.Value)
                            {
                                empleado = new EmpleadoDAO().obtenerEmpleado((int)lector["idempleado"]);
                            }

                            Venta venta = new Venta(
                                (int)lector["idVenta"],
                                (DateTime)lector["fecha"],
                                Convert.ToDecimal(lector["totalPagar"]),
                                Convert.ToDecimal(lector["cantPagada"]),
                                (string)lector["comentarios"],
                                ((string)lector["estatus"])[0],
                                cliente,
                                empleado
                                );
                            ventas.Add(venta);
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
            return ventas;
        }
    }
}
