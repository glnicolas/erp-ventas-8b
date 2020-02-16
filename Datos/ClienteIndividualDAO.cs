using ERP_ventas.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_ventas.Datos
{
    class ClienteIndividualDAO
    {

        public List<ClienteIndividual> ConsultaGeneral(string sql_where, List<string> parametros, List<object> valores)
        {
            List<ClienteIndividual> clientesInd = new List<ClienteIndividual>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    string cadena_sql = "select * from ClienteIndividual " + sql_where;
                    //idCliente	nombre	apaterno	amaterno	sexo

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
                            ClienteIndividual cliente = new ClienteIndividual(
                                 (string)lector["nombre"],
                                 (string)lector["apaterno"],
                                 (string)lector["amaterno"],
                                 ((string)lector["sexo"])[0]
                                 );
                            clientesInd.Add(cliente);
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
            return clientesInd;
        }

        internal bool ValidarRegistro(ClienteIndividual cliente)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    string cadena_sql = "select idcliente from ClienteIndividual where nombre=@nombre and apaterno=@ap and amaterno=@am and sexo=@sexo ";

                    SqlCommand comando = new SqlCommand(cadena_sql, conexion);
                    comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
                    comando.Parameters.AddWithValue("@ap", cliente.Apaterno);
                    comando.Parameters.AddWithValue("@am", cliente.Amaterno);
                    comando.Parameters.AddWithValue("@sexo", cliente.Sexo_char);
                    conexion.Open();
                    SqlDataReader lector = comando.ExecuteReader();

                    if (lector.HasRows)
                        return false;
                    else
                        return true;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error relacionado con la BD. [ClienteIndividualDAO] \n Anota este error y contacta al administrador.\n" + ex.Message);
            }
        }

        public bool Registrar(ClienteIndividual cliente, int ID)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    string cadena_sql = "insert into ClienteIndividual values (@id, @nombre, @ap, @am, @sexo) ";

                    SqlCommand comando = new SqlCommand(cadena_sql, conexion);
                    comando.Parameters.AddWithValue("@id", ID);
                    comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
                    comando.Parameters.AddWithValue("@ap", cliente.Apaterno);
                    comando.Parameters.AddWithValue("@am", cliente.Amaterno);
                    comando.Parameters.AddWithValue("@sexo", cliente.Sexo_char);
                    conexion.Open();
                    int rows = comando.ExecuteNonQuery();
                    if (rows!=0)
                        return true;
                    else
                        return false;
                }

            }
            catch (SqlException ex)
            {
                throw new Exception("Error relacionado con la BD. [ClienteIndividualDAO] \n Anota este error y contacta al administrador.\n" + ex.Message);
            }
        }

    }
}
