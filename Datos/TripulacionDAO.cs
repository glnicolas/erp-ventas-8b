using ERP_ventas.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_ventas.Datos
{
    class TripulacionDAO : Paginacion
    {
        public TripulacionDAO() {
            table = "VTripilacion"; //Nonbre de la vista.
            order_by = "ID empleado"; //Nombre de la columna para ordenar los registros.
            rows_per_page = 3; //Cantidad de registros por pagina.
            try
            {
                CalculatePages(); //Calcula la cantidad de páginas.
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Tripulacion> ConsultaGeneral(string sql_where, List<string> parametros, List<object> valores) {
            List<Tripulacion> tripulaciones = new List<Tripulacion>();

            try 
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    string cadena_sql = "select idEmpleado, idEnvio, rol from Tripulacion";
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
                            Tripulacion tripulacion = new Tripulacion(
                                (int)lector["idEmpleado"],
                                (int)lector["idEnvio"],
                                (string)lector["rol"]
                                );
                            tripulaciones.Add(tripulacion);
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
            catch(Exception ex) {
                throw new Exception("Error relacionado con la BD. [TripulacionDAO.c] \n Anota este error y contacta al administrador.\n" + ex.Message);
            }
            return tripulaciones;
        }

        public bool Validar(int tipo, Tripulacion tripulacion) {
            try 
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    string cadena_sql = "";
                    if (tipo == 0)
                        cadena_sql = "select idEmpleado from Tripulacion where idEmpleado=@idEmpleado";
                    else
                        cadena_sql = "select idEmpleado from Tripulación where idEmpleado=@idEMpleado and idEnvio=@idEnvio";

                    SqlCommand comando = new SqlCommand(cadena_sql, conexion);
                    comando.Parameters.AddWithValue("@idEmpleado", tripulacion.idEmpleado);
                    //if (tipo == 1)
                    //    comando.Parameters.AddWithValue();
                }
            }
            catch
            {
                
            }
            return false;
        }

        public object Registrar(Tripulacion tr) 
        {
            object resultado = new object();
            try
            {
                //if (Validar(0, tr)) 
                //{
                    using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                    {
                        string cadena_sql = "insert into Tripulacion values(@idEmpleado, @idEnvio, @rol, 'A')";

                        SqlCommand comando = new SqlCommand(cadena_sql, conexion);
                        comando.Parameters.AddWithValue("@idEmpleado", tr.idEmpleado);
                        comando.Parameters.AddWithValue("@idEnvio", tr.idEnvio);
                        comando.Parameters.AddWithValue("@rol", tr.rol);
                        conexion.Open();

                        int cant_registros = (int)comando.ExecuteNonQuery();
                        conexion.Close();
                        if (cant_registros == 1)
                            resultado = true;
                        else
                            resultado = "Se ha generado un error no especificado";
                        }
                //}
                //else
                //{
                //    resultado = "Error: Ya existe una unidad con datos en común";
                //}
            }
            catch (SqlException ex)
            {
                throw new Exception("Error relacionado con la BD. [ClienteIndividualDAO.R] \n Anota este error y contacta al administrador.\n" + ex.Message);
            }
            return resultado;
        }

        public object Editar(Tripulacion tr) 
        {
            object resultado = new object();
            try
            {
                //if (Validar(1, tr))
                //{
                    using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                    {
                        string cadena_sql = "update Tripulacion set @rol=rol";

                        SqlCommand comando = new SqlCommand(cadena_sql, conexion);
                        comando.Parameters.AddWithValue("@idEmpleado", tr.idEmpleado);
                        comando.Parameters.AddWithValue("@idEnvio", tr.idEnvio);
                        comando.Parameters.AddWithValue("@rol", tr.rol);
                        conexion.Open();

                        int cant_registros = (int)comando.ExecuteNonQuery();
                        conexion.Close();
                        if (cant_registros==1) 
                        {
                            resultado = true;
                        }
                        else
                            resultado = "Se ha generado un error no especificado";
                    }
                //}
                //else 
                //{
                    resultado = "Error: Ya existe una unidad con datos en común";
                //}
            }
            catch(SqlException ex) 
            {
            }
            return resultado;
        }

        internal void Eliminar(int ID) 
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion)) 
                {
                    string cadena_sql = "update Tripulacion set estatus 'I' where idEmpleado = @id";

                    SqlCommand comando = new SqlCommand(cadena_sql, conexion);
                    comando.Parameters.AddWithValue("@id", ID);
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();
                }
            }
            catch (SqlException ex) 
            {
                throw new Exception("Error relacionado con la BD. [TripulacionDAO.E] \n Anota este error y contacta al administrador.\n" + ex.Message);
            }
        }
    }
}
