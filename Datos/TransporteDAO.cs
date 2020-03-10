using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_ventas.Modelo;
using System.Data.SqlClient;
using System.Data;

namespace ERP_ventas.Datos
{
    class TransporteDAO : Paginacion
    {
       
        public List<Transporte> ConsultaGeneral(string sql_where, List<string> parametros, List<object> valores)
        {
            List<Transporte> uniTrans = new List<Transporte>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    string cadena_sql = "select * from UnidadesTransporte " + sql_where;
                    //idUnidadTransporte placas  marca modelo  anio capacidad   estatus

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
                                 ((string)lector["estatus"])[0]
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

        internal void Eliminar(int ID)
        {
            try
            {
                    using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                    {
                        string cadena_sql = "update UnidadesTransporte set estatus= 'I' where idUnidadTransporte=@id";

                        SqlCommand comando = new SqlCommand(cadena_sql, conexion);
                        comando.Parameters.AddWithValue("@id", ID);
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        conexion.Close();
                    }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error relacionado con la BD. [ClienteIndividualDAO.E] \n Anota este error y contacta al administrador.\n" + ex.Message);
            }
        }

        public DataTable consultagral()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
            {
                string sql = "select idunidadtransporte 'Nombre col' from UnidadesTransporte";
                SqlDataAdapter adaptador = new SqlDataAdapter(sql, conexion);
                adaptador.Fill(dt);
            }
            return dt;
        }

        public object Registrar(Transporte tr)
        {
            object resultado = new object();
            try
            {
                if (Validar(0, tr))
                {
                    using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                    {
                        string cadena_sql = "insert into UnidadesTransporte values (@placas, @marca, @modelo, @anio, @cap, @est)";

                        SqlCommand comando = new SqlCommand(cadena_sql, conexion);
                        comando.Parameters.AddWithValue("@placas", tr.Placas);
                        comando.Parameters.AddWithValue("@marca", tr.Marca);
                        comando.Parameters.AddWithValue("@modelo", tr.Modelo);
                        comando.Parameters.AddWithValue("@anio", tr.Anio);
                        comando.Parameters.AddWithValue("@cap", tr.Capacidad);
                        comando.Parameters.AddWithValue("@est", tr.Estatus);
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

        public object Editar(Transporte tr)
        {
            object resultado = new object();
            try
            {
                if (Validar(1, tr))
                {
                    using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                    {
                        string cadena_sql = "update UnidadesTransporte set placas=@placas, marca= @marca,modelo = @modelo, anio= @anio,capacidad= @cap," +
                            "estatus= @est where idUnidadTransporte=@id";

                        SqlCommand comando = new SqlCommand(cadena_sql, conexion);
                        comando.Parameters.AddWithValue("@placas", tr.Placas);
                        comando.Parameters.AddWithValue("@marca", tr.Marca);
                        comando.Parameters.AddWithValue("@modelo", tr.Modelo);
                        comando.Parameters.AddWithValue("@anio", tr.Anio);
                        comando.Parameters.AddWithValue("@cap", tr.Capacidad);
                        comando.Parameters.AddWithValue("@est", tr.Estatus);
                        comando.Parameters.AddWithValue("@id", tr.ID);
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
                throw new Exception("Error relacionado con la BD. [ClienteIndividualDAO.E] \n Anota este error y contacta al administrador.\n" + ex.Message);
            }
            return resultado;
        }

        public TransporteDAO()
        {
            table = "VUnidadesTransporte";  //Nombre de la tabla o vista
            order_by = "placas"; //Nombre de la columna para ordenar los registros
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


        public bool Validar(int tipo, Transporte tr)
        {
            // tipo 0 -> insert ; 1 -> update

            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    string cadena_sql = "";
                    if (tipo == 0)
                        cadena_sql = "select idUnidadTransporte from UnidadesTransporte where placas=@placas ";

                    else
                        cadena_sql = "select idUnidadTransporte from UnidadesTransporte where placas=@placas and idUnidadTransporte!=@id";

                    SqlCommand comando = new SqlCommand(cadena_sql, conexion);
                    comando.Parameters.AddWithValue("@placas", tr.Placas);
                    comando.Parameters.AddWithValue("@marca", tr.Marca);
                    comando.Parameters.AddWithValue("@modelo", tr.Modelo);
                    comando.Parameters.AddWithValue("@anio", tr.Anio);
                    comando.Parameters.AddWithValue("@cap", tr.Capacidad);
                    if (tipo == 1)
                        comando.Parameters.AddWithValue("@id", tr.ID);
                    conexion.Open();

                    SqlDataReader lector = comando.ExecuteReader();

                    if(lector.HasRows)
                    {
                        conexion.Close();
                        return false;
                    }
                    else
                    {
                        conexion.Close();
                        return true;
                    }

                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error relacionado con la BD. [ClienteIndividualDAO.V] \n Anota este error y contacta al administrador.\n" + ex.Message);
            }
        }
    }
}
