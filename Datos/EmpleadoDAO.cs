using ERP_ventas.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_ventas.Datos
{
    class EmpleadoDAO
    {

        public Empleado obtenerEmpleado(int idEmpleado)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    string cadena_sql = "Select idempleado, nombre, apaterno, amaterno, fotografia from Empleados where idempleado=@id ";
                    //idEmpleado	nombre	apaterno    amaterno	foto

                    SqlCommand comando = new SqlCommand(cadena_sql, conexion);

                    conexion.Open();
                    comando.Parameters.AddWithValue("@id", idEmpleado);

                    SqlDataReader lector = comando.ExecuteReader();
                    if (lector.HasRows)
                    {
                        Empleado empleado;
                        lector.Read();
                        {
                             // Otra opción de recuperar los datos del lector
                             //empleado = new Empleado(
                             //    lector.GetInt32(0),
                             //    lector.GetString(1),
                             //    lector.GetString(2),
                             //    lector.GetString(3),
                             //    (byte[])lector["fotografia"]
                             //    );
                            empleado = new Empleado(
                                 (int)lector["idempleado"],
                                 (string)lector["nombre"],
                                 (string)lector["apaterno"],
                                 (string)lector["amaterno"],
                                 (byte[])lector["fotografia"]
                                 );

                        }
                        lector.Close();
                        conexion.Close();
                        return empleado;
                    }
                    else
                    {
                        lector.Close();
                        conexion.Close();
                        return null;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error relacionado con la BD. [EmpleadoDAO] \n Anota este error y contacta al administrador.\n" + ex.Message);
            }

        }
    }
}
