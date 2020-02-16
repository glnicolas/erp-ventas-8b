using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_ventas.Modelo;
using System.Data.SqlClient;

namespace ERP_ventas.Datos
{
    class ClienteTiendaDAO
    {
        public ClienteTienda CrearCliente("saf")
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
