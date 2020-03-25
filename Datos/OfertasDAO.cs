using ERP_ventas.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    string cadena_sql = "select * from ofertas " + sql_where;
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
                             Oferta oferta = new Oferta(
                                 (int)lector["idOferta"],
                                 (string)lector["nombre"],
                                 (string)lector["descripcion"],
                                 (float)lector["porDescuento"],
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
                        string cadena_sql = "insert into UnidadesTransporte values (@placas, @marca, @modelo, @anio, @cap, @est)";

                        SqlCommand comando = new SqlCommand(cadena_sql, conexion);
                        //comando.Parameters.AddWithValue("@placas", tr.Placas);
                        //comando.Parameters.AddWithValue("@marca", tr.Marca);
                        //comando.Parameters.AddWithValue("@modelo", tr.Modelo);
                        //comando.Parameters.AddWithValue("@anio", tr.Anio);
                        //comando.Parameters.AddWithValue("@cap", tr.Capacidad);
                        //comando.Parameters.AddWithValue("@est", tr.Estatus);
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
    }
}
