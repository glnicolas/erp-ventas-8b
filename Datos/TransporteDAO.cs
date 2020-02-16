using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_ventas.Modelo;
using System.Data.SqlClient;

namespace ERP_ventas.Datos
{
    class TransporteDAO
    {
        
        //public Transporte obtenerTransporte(int idTransporte) { 
            
        //}

        //public Transporte agregarTransporte(Transporte tp)
        //{
          //  Transporte Tp = new Transporte(tp.ID, tp.Placas, tp.Marca, tp.Modelo, tp.Anio, tp.Capacidad);
           // try
            //{
              //  using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion)) {
                //    string sqlcad = "insert into UnidadesTransporte values " + "'" + Tp.ID+","+Tp.Placas+","+Tp.Marca
                  //      +","+Tp.Modelo+","+Tp.Anio+","+Tp.Capacidad+"'";
               // }
           // }
            //catch (Exception ex)
            //{
              //  Mensajes.Error(ex.Message + ex.StackTrace);
                //throw;
            //}
        }

        public Transporte ObtenerTransporte(int idUnidadTransporte)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    string cadena_sql = "Select * from unidadesTransporte where idUnidadTrasnporte=@id ";
                    

                    SqlCommand comando = new SqlCommand(cadena_sql, conexion);

                    conexion.Open();
                    comando.Parameters.AddWithValue("@id", idUnidadTransporte);

                    SqlDataReader lector = comando.ExecuteReader();
                    if (lector.HasRows)
                    {
                        Transporte tras;
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
                            tras = new Transporte(
                                 (int)lector["idUnidadTransporte"],
                                 (string)lector["placas"],
                                 (string)lector["marca"],
                                 (string)lector["modelo"],
                                 (int)lector["anio"],
                                 (int)lector["capacidad"],
                                 (char)lector["estatus"]
                                 );

                        }
                        lector.Close();
                        conexion.Close();
                        return tras;
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
