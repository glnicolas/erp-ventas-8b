using ERP_ventas.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_ventas.Datos
{
    class ProductosOfertaDAO
    {
        public List<Producto> ConsultaGeneral(string sql_where, List<string> parametros, List<object> valores)
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    string cadena_sql = "select * from Productos_oferta " + sql_where;
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
                            Producto producto = new Producto(
                                 (int)lector["ID"],
                                 (string)lector["Marca"],
                                 (string)lector["Estilo"],
                                 (string)lector["Categoria"],
                                 (string)lector["nombre"],
                                 (string)lector["Descripcion"],
                                 ((string)lector["genero"])[0],
                                 (double)lector["precioVenta"],
                                 new ProductoDAO().ConsultarimagenProducto((int)lector["ID"])
                                 );
                            producto.Estatus = ((string)lector["estatus"])[0];
                            productos.Add(producto);
                        }
                    }
                    lector.Close();
                    conexion.Close();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error relacionado con la BD. [ProductoDAO.C] \n Anota este error y contacta al administrador.\n" + ex.Message);
            }
            return productos;
        }

        public bool Agregar(int ID_Oferta, List<Producto> productos)
        {
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
            {
                conexion.Open();

                SqlCommand comando = conexion.CreateCommand();
                SqlTransaction trans;

                // Start a local transaction.
                trans = conexion.BeginTransaction("InsertarProductosOferta");

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                comando.Connection = conexion;
                comando.Transaction = trans;

                try
                {
                    foreach (Producto p in productos)
                    {
                        comando.Parameters.Clear();
                        if (p.Agregado)//update
                        {
                            comando.CommandText = "update OfertasProductos set estatus=@estatus where idoferta=@idoferta and idproducto=@idprod";
                            comando.Parameters.AddWithValue("@estatus", p.Estatus);
                        }
                        else//insert
                            comando.CommandText = "insert into OfertasProductos values (@idprod, @idoferta, 'A')";

                        comando.Parameters.AddWithValue("@idoferta", ID_Oferta);
                        comando.Parameters.AddWithValue("@idprod", p.ID);
                        comando.ExecuteNonQuery();
                    }

                    // Attempt to commit the transaction.
                    trans.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("  Message: {0}", ex.Message);

                    // Attempt to roll back the transaction.
                    try
                    {
                        trans.Rollback();
                        throw new Exception("Error con la BD. Anota este error y contacta al administrador.\n" + ex.Message);
                    }
                    catch (Exception ex2)
                    {
                        // This catch block will handle any errors that may have occurred
                        // on the server that would cause the rollback to fail, such as
                        // a closed connection.
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                        throw new Exception(ex2.Message);
                    }
                }
            }


        }

        public List<Oferta> BuscarOfertaProducto(int idProducto)
        {
            List<Oferta> ofertas = new List<Oferta>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    string cadena_sql = "sp_buscarProductoEnOfertas";

                    SqlCommand comando = new SqlCommand(cadena_sql, conexion);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    conexion.Open();
                    comando.Parameters.AddWithValue("@id", idProducto);


                    SqlDataReader lector = comando.ExecuteReader();
                    if (lector.HasRows)
                    {
                        while (lector.Read())
                        {
                            Oferta oferta = new Oferta(
                                (int)lector["idOferta"],
                                (string)lector["nombre"],
                                (double)lector["porDescuento"],
                                (int)lector["canMinProducto"]);
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
    }
}
