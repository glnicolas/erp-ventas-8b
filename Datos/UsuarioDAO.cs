using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using ERP_ventas.Modelo;

namespace ERP_ventas.Datos
{
    class UsuarioDAO
    {
       

        public Usuario iniciarSesion(string user, string pass)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    string cadena_sql = "Select idusuario from Usuarios where nombre collate Latin1_General_CS_AS =@usuario " +
                        "and contra collate Latin1_General_CS_AS = @passwd and estatus='A'";
                    //idUsuario	nombre	contra	estatus	tipo	fechaRegistro	idEmpleado

                    SqlCommand comando = new SqlCommand(cadena_sql, conexion);

                    conexion.Open();
                    comando.Parameters.AddWithValue("@usuario", user);
                    comando.Parameters.AddWithValue("@passwd", pass);

                    SqlDataReader lector = comando.ExecuteReader();
                    if (lector.HasRows)
                    {
                        Usuario usuario;
                        lector.Read();
                        {

                            usuario = obtenerUsuario(lector.GetInt32(0));
                        }
                        lector.Close();
                        conexion.Close();
                        return usuario;
                    }
                    else
                    {
                        lector.Close();
                        conexion.Close();
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error relacionado con la BD. [UsuarioDAO] \n" + ex.Message);
            }
        }

        public Usuario obtenerUsuario(int idUsuario)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    string cadena_sql = "Select * from Usuarios where idusuario=@id";
                    //idUsuario	nombre	contra	estatus	tipo	fechaRegistro	idEmpleado

                    SqlCommand comando = new SqlCommand(cadena_sql, conexion);

                    conexion.Open();
                    comando.Parameters.AddWithValue("@id", idUsuario);

                    SqlDataReader lector = comando.ExecuteReader();
                    if (lector.HasRows)
                    {
                        Usuario usuario;
                        lector.Read();
                        {
                            Empleado empleado = new EmpleadoDAO().obtenerEmpleado(lector.GetInt32(6));
                            usuario = new Usuario(
                                lector.GetInt32(0),
                                lector.GetString(1),
                                lector.GetString(2),
                                lector.GetString(3)[0],
                                lector.GetString(4),
                                lector.GetDateTime(5),
                                empleado
                                );
                        }
                        lector.Close();
                        conexion.Close();
                        return usuario;
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
                throw new Exception("Error relacionado con la BD. [UsuarioDAO] \n" + ex.Message);
            }
        }

    }
}
