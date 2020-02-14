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
            
            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-QLD6ULH;Initial Catalog=ERP2020;Persist Security Info=True;User ID=sa; Password=clan.3cp");//Properties.Settings.Default.ConBD);
            conexion.Open();

            SqlParameter param_usuario = new SqlParameter("@usuario", user);
            SqlParameter param_passwd = new SqlParameter("@passwd", pass);

            SqlCommand comando = new SqlCommand("Select * from Usuarios where nombre collate Latin1_General_CS_AS =@usuario " +
                "and contra collate Latin1_General_CS_AS = @passwd and estatus='A'");
            //idUsuario	nombre	contra	estatus	tipo	fechaRegistro	idEmpleado
            comando.Connection = conexion;
            comando.Parameters.Add(param_usuario);
            comando.Parameters.Add(param_passwd);

            SqlDataReader lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                Usuario usuario;
                lector.Read();
                {
                    usuario = new Usuario(
                        lector.GetInt32(0),
                        lector.GetString(1),
                        lector.GetString(2),
                        lector.GetString(3)[0],
                        lector.GetString(4),
                        lector.GetDateTime(5),
                        lector.GetInt32(6) //debe ser reemplazado por un objeto Empleado
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
}
