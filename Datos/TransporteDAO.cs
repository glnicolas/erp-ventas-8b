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

    public List<Transporte> ConsultaGeneral(string sql_where, List<string> parametros, List<object> valores)
    {
        List<Transporte> uniTrans = new List<Transporte>();
        try
        {
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
            {
                string cadena_sql = "select * from UnidadesTransporte " + sql_where;

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
                        Transporte trans = new Transporte(
                             (int)lector["idUnidadTransporte"],
                             (string)lector["placas"],
                             (string)lector["marca"],
                             (string)lector["modelo"],
                             (int)lector["anio"],
                             (int)lector["capacidad"],
                             (char)lector["estatus"]
                             );
                        uniTrans.Add(trans);
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
        catch (SqlException ex)
        {
            throw new Exception("Error relacionado con la BD. [ClienteIndividualDAO] \n Anota este error y contacta al administrador.\n" + ex.Message);
        }
        return uniTrans;
    }

}
}
