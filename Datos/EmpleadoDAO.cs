using ERP_ventas.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_ventas.Datos
{
    class EmpleadoDAO
    {

        public List<Empleado> ConsultaGeneral(string sql_where, List<string> parametros, List<object> valores)
        {
            List<Empleado> env = new List<Empleado>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    string cadena_sql = "select idEmpleado,Nombre,Apaterno,Amaterno from Empleados" + sql_where;
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
                            Empleado envi = new Empleado(
                                (int)lector["idEmpleado"],
                                (string)lector["Nombre"],
                                (string)lector["Apaterno"],
                                (string)lector["Amaterno"]
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
