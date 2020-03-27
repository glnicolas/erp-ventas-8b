using ERP_ventas.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_ventas.Datos
{
    class OfertasDAO : Paginacion
    {
        public OfertasDAO()
        {

            table = "Ofertas_General";  //Nombre de la tabla o vista
            order_by = "Nombre"; //Nombre de la columna para ordenar los registros
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

        public List<Oferta> ConsultaGeneral(string sql_where, List<string> parametros, List<object> valores) {
            List<Oferta> ofertas = new List<Oferta>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    string cadena_sql = "SELECT idOferta, nombre, descripcion, porDescuento, CONVERT(varchar,fechaInicio,103) as fechaInicio, CONVERT(varchar,fechaFin,103) as fechaFin, canMinProducto, estatus FROM Ofertas " + sql_where;
                    // idOferta nombre  descripcion porDescuento    fechaInicio fechaFin    canMinProducto estatus

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
                            //MessageBox.Show(" s"+((double)lector["porDescuento"]), "f");
                             Oferta oferta = new Oferta(
                                 (int)lector["idOferta"],
                                 (string)lector["nombre"],
                                 (string)lector["descripcion"],
                                 (double)lector["porDescuento"],
                                 (string)lector["fechaInicio"],
                                 (string)lector["fechaFin"],
                                 (int)lector["canMinProducto"],
                                 (((string)lector["estatus"])[0]+"")
                                 //Se castea primero como string y después se toma el Char en la Pos 0
                                 );
                            ofertas.Add(oferta);
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
                throw new Exception("Error relacionado con la BD. [OfertaDAO.c] \n Anota este error y contacta al administrador.\n" + ex.Message);
            }
            return ofertas;
        }

        public object Registrar(Oferta of)
        {
            object resultado = new object();
            try
            {
                // tipo 0 -> insert ; 1 -> update
                //Validar(0, tr)
                if (true)
                {
                    using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                    {
                        string cadena_sql = "insert into Ofertas values(@nombre,@descripcion,@descuento,@fInicio,@fFin,@cantMinProd,'A')";

                        SqlCommand comando = new SqlCommand(cadena_sql, conexion);
                        comando.Parameters.AddWithValue("@nombre", of.nombre);
                        comando.Parameters.AddWithValue("@descripcion", of.descripcion);
                        comando.Parameters.AddWithValue("@descuento", of.porDescuento);
                        comando.Parameters.AddWithValue("@fInicio", of.fechaInicio);
                        comando.Parameters.AddWithValue("@fFin", of.fechaFin);
                        comando.Parameters.AddWithValue("@cantMinProd", of.canMinProducto);
                        conexion.Open();

                        int cant_registros = (int)comando.ExecuteNonQuery();
                        conexion.Close();
                        if (cant_registros == 1)
                        {
                            resultado = true;
                        }
                        else
                        {
                            resultado = "Se ha generado un error no especificado";
                        }
                    }
                }
                else
                {
                    resultado = "Error: Ya existe una unidad con datos en común";
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error relacionado con la BD. [ClienteIndividualDAO.R] \n Anota este error y contacta al administrador.\n" + ex.Message);
            }
            return resultado;
        }

        internal void Eliminar(int ID)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    string cadena_sql = "update Ofertas set estatus= 'I' where idOferta=@id";

                    SqlCommand comando = new SqlCommand(cadena_sql, conexion);
                    comando.Parameters.AddWithValue("@id", ID);
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error relacionado con la BD. [ClienteDAO.E] \n Anota este error y contacta al administrador.\n" + ex.Message);
            }
        }
    }
}
