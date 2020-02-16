using ERP_ventas.Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_ventas.Datos
{
    class ClienteDAO
    {

        
        public List<Cliente> ConsultaGeneral(string sql_where, List<string> parametros, List<object> valores)
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    string cadena_sql = "select * from Clientes " + sql_where;
                    //idCliente	direccion	codidoPostal	rfc	telefono	email	tipo	estatus     idCiudad

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
                            Cliente cliente = new Cliente(
                                 (int)lector["idCliente"],
                                 (string)lector["direccion"],
                                 (string)lector["codidoPostal"],
                                 (string)lector["rfc"],
                                 (string)lector["telefono"],
                                 (string)lector["email"],
                                 ((string)lector["tipo"])[0], //Se castea primero como string y después se toma el Char en la Pos 0
                                 ((string)lector["estatus"])[0], //Se castea primero como string y después se toma el Char en la Pos 0
                                 (int)lector["idCiudad"]
                                 );
                            clientes.Add(cliente);
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
                foreach(Cliente cliente in clientes)
                {
                    //List<string> parametros = new List<string>();
                    //List<object> valores = new List<object>();
                    //Reutilizar las listas que ya existen
                    parametros.Clear();
                    valores.Clear();
                    parametros.Add("@id");
                    valores.Add(cliente.ID);
                    if (cliente.Tipo == 'I')
                    {
                        //Realizar consulta para traer los datos en clienteIndividual
                        List<ClienteIndividual> clientesind = new ClienteIndividualDAO().ConsultaGeneral(" where idCliente=@id", parametros, valores);
                        if (clientesind.Count == 1)
                        {
                            cliente.InfoCliente = clientesind[0]; //Se asigna la posición 0 porque sólo debe de encontrar un registro en ClientesIndividual
                        }
                    }
                    else
                    {
                        //Realizar consulta para traer los datos en clienteTienda
                        //Crear el método ConsultaGeneral en una clase ClienteTiendaDAO y una clae ClienteTienda para almacenar los datos. 
                        //Asignarlo de igual manera a cliente.InfoCliente
                    }
                }

            }
            catch (SqlException ex)
            {
                throw new Exception("Error relacionado con la BD. [ClienteIndividualDAO] \n Anota este error y contacta al administrador.\n" + ex.Message);
            }
            return clientes;
        }
    }
}
