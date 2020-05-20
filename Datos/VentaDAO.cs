using ERP_ventas.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_ventas.Datos
{
    class VentaDAO
    {

        public List<Venta> ConsultaGeneral(string sql_where, List<string> parametros, List<object> valores)
        {
            List<Venta> ventas = new List<Venta>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    string cadena_sql = "select * from ventas " + sql_where;

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
                            Empleado empleado = null;
                            Cliente cliente = null;
                            if (lector["idempleado"] != DBNull.Value)
                            {
                                cliente = new ClienteDAO().ConsultaGeneral(
                                    " where idCliente = @id", new List<string>() { "@id" }, new List<object>() { (int)lector["idCliente"] })[0];
                            }
                            if (lector["idempleado"] != DBNull.Value)
                            {
                                empleado = new EmpleadoDAO().obtenerEmpleado((int)lector["idempleado"]);
                            }

                            Venta venta = new Venta(
                                (int)lector["idVenta"],
                                (DateTime)lector["fecha"],
                                Convert.ToDecimal(lector["totalPagar"]),
                                Convert.ToDecimal(lector["cantPagada"]),
                                (string)lector["comentarios"],
                                ((string)lector["estatus"])[0],
                                cliente,
                                empleado
                                );
                            venta.Productos = DetalleVenta(venta.ID);
                            ventas.Add(venta);
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
            return ventas;
        }

        public Venta Registrar()
        {
            Venta venta = null;
            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    string cadena_sql = "sp_registrarVenta";
                    SqlCommand comando = new SqlCommand(cadena_sql, conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    conexion.Open();
                    SqlDataReader lector = comando.ExecuteReader();
                    if (lector.Read())
                    {
                        venta = new Venta((int)lector["idVenta"],
                                          (DateTime)lector["fecha"],
                                          ((string)lector["estatus"])[0]);
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en VentaDAO[Registrar]. Contacta al administrador\n" + ex.Message);
            }
            return venta;
        }

        public bool Cancelar(int id)
        {
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
            {
                conexion.Open();
                string cadena_sql = "update ventas set estatus='C' where idventa=@id";
                SqlCommand comando = conexion.CreateCommand();
                SqlTransaction trans;
                trans = conexion.BeginTransaction("CancelarVenta");
                comando.Connection = conexion;
                comando.Transaction = trans;
                try
                {
                    comando.CommandText = cadena_sql;
                    comando.Parameters.AddWithValue("@id", id);
                    if (comando.ExecuteNonQuery() == 1)
                    {
                        trans.Commit();
                        return true;
                    }
                    else
                    {
                        trans.Rollback();
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("  Message: {0}", ex.Message);
                    try
                    {
                        trans.Rollback();
                        throw new Exception("Error con la BD. Anota este error y contacta al administrador.\n" + ex.Message);
                    }
                    catch (Exception ex2)
                    {
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                        throw new Exception(ex2.Message);
                    }
                }
            }
        }

        public bool Eliminar(int id)
        {
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
            {
                conexion.Open();
                string cadena_sql = "update ventas set estatus='I' where idventa=@id";
                SqlCommand comando = conexion.CreateCommand();
                SqlTransaction trans;
                trans = conexion.BeginTransaction("CancelarVenta");
                comando.Connection = conexion;
                comando.Transaction = trans;
                try
                {
                    comando.CommandText = cadena_sql;
                    comando.Parameters.AddWithValue("@id", id);
                    if (comando.ExecuteNonQuery() == 1)
                    {
                        trans.Commit();
                        return true;
                    }
                    else
                    {
                        trans.Rollback();
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("  Message: {0}", ex.Message);
                    try
                    {
                        trans.Rollback();
                        throw new Exception("Error con la BD. Anota este error y contacta al administrador.\n" + ex.Message);
                    }
                    catch (Exception ex2)
                    {
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                        throw new Exception(ex2.Message);
                    }
                }
            }
        }

        internal bool Actualizar(Venta venta)
        {
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
            {
                conexion.Open();
                string cadena_sql = "update ventas set fecha=@fecha, totalPagar=@total, cantPagada=@cantpagada, " +
                    " comentarios=@com, estatus=@estatus, idcliente=@idcliente, idempleado=@idempleado where idventa=@id";
                //idVenta	fecha	totalPagar	cantPagada	comentarios	estatus	idCliente	idEmpleado
                SqlCommand comando = conexion.CreateCommand();
                SqlTransaction trans;
                trans = conexion.BeginTransaction("ActualizarVenta");
                comando.Connection = conexion;
                comando.Transaction = trans;
                try
                {
                    comando.CommandText = cadena_sql;
                    comando.Parameters.AddWithValue("@id", venta.ID);
                    comando.Parameters.AddWithValue("@fecha", venta.Fecha);
                    comando.Parameters.AddWithValue("@total", venta.TotalPagar);
                    comando.Parameters.AddWithValue("@cantpagada", venta.CantidadPagada);
                    comando.Parameters.AddWithValue("@com", venta.Comentarios);
                    comando.Parameters.AddWithValue("@estatus", venta.EstatusChar);
                    comando.Parameters.AddWithValue("@idcliente", venta.ClienteObj.ID);
                    comando.Parameters.AddWithValue("@idempleado", venta.EmpleadoObj.ID);
                    if (comando.ExecuteNonQuery() == 1)
                    {
                        comando.CommandText = "select idventadetalle from VentasDetalle where idVenta=@id";

                        SqlDataReader lector = comando.ExecuteReader();
                        List<int> idventasdetalles = new List<int>();
                        while (lector.Read())
                        {
                            idventasdetalles.Add(lector.GetInt32(0));
                            //comando.Parameters.Clear();
                            //comando.CommandText = "delete from VentasOfertas where idVentaDetalle=@id";
                            //comando.Parameters.AddWithValue("@id", idventadetalle);
                            //comando.ExecuteNonQuery();
                        }
                        lector.Close();

                        foreach(int id in idventasdetalles)
                        {
                            comando.Parameters.Clear();
                            comando.CommandText = "delete from VentasOfertas where idVentaDetalle=@id";
                            comando.Parameters.AddWithValue("@id", id);
                            comando.ExecuteNonQuery();
                        }

                        comando.Parameters.Clear();

                        comando.Parameters.AddWithValue("@id", venta.ID);
                        comando.CommandText = "delete from VentasDetalle where idVenta=@id";
                        comando.ExecuteNonQuery();
                        foreach (Producto producto in venta.Productos)
                        {
                            comando.Parameters.Clear();
                            comando.CommandText = "sp_registrarDetalleVenta";
                            comando.CommandType = CommandType.StoredProcedure;
                            comando.Parameters.AddWithValue("@unitario", producto.Precio_venta);
                            comando.Parameters.AddWithValue("@cantidad", producto.Cantidad);
                            comando.Parameters.AddWithValue("@subtotal", producto.Suma);
                            comando.Parameters.AddWithValue("@idventa", venta.ID);
                            comando.Parameters.AddWithValue("@iddetalle", producto.detalleSeleccionado.ID);
                            int idventadetalle = Convert.ToInt32(comando.ExecuteScalar());
                            if (producto.Oferta != null)
                            {
                                comando.CommandType = CommandType.Text;
                                comando.Parameters.Clear();
                                comando.CommandText = "insert into VentasOfertas values (@idventadetalle, @idproducto, @idoferta, 'A')";
                                //idVentaDetalle	idProducto	idOferta
                                comando.Parameters.AddWithValue("@idventadetalle", idventadetalle);
                                comando.Parameters.AddWithValue("@idproducto", producto.ID);
                                comando.Parameters.AddWithValue("@idoferta", producto.Oferta.idOferta);
                                comando.ExecuteNonQuery();
                            }
                        }
                        trans.Commit();
                        return true;
                    }
                    else
                    {
                        trans.Rollback();
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("  Message: {0}", ex.Message);
                    try
                    {
                        trans.Rollback();
                        throw new Exception("Error con la BD. Anota este error y contacta al administrador.\n" + ex.Message);
                    }
                    catch (Exception ex2)
                    {
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                        throw new Exception(ex2.Message);
                    }
                }
            }
        }

        internal List<Producto> DetalleVenta(int idventa)
        {
            List<Producto> productos = new List<Producto>();
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
            {
                try
                {
                    List<int> id_detallesproducto = new List<int>();
                    string cadena_sql = "select * from VentasDetalle where idVenta=@id";
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(cadena_sql, conexion);
                    comando.Parameters.AddWithValue("@id", idventa);
                    SqlDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        Producto producto = new Producto();
                        producto.Cantidad = Convert.ToInt32(lector["cantidad"]);
                        producto.IDVentaDetalle = Convert.ToInt32(lector["idVentaDetalle"]);
                        producto.Precio_venta = (double)lector["precioUnitario"];
                        producto.detalleSeleccionado = new DetalleProducto((int)lector["idProductoDetalle"]);
                        productos.Add(producto);
                    }
                    lector.Close();

                    foreach(Producto producto in productos)
                    {
                        comando.Parameters.Clear();
                        comando.CommandText = "select idProducto from DetalleProductos where idProductoDetalle=@idDetallep";
                        comando.Parameters.AddWithValue("@idDetallep", producto.detalleSeleccionado.ID);
                        producto.ID = (int)comando.ExecuteScalar();
                        Producto productoEncontrado = new ProductoDAO().consultaGeneral(" where ID=@id", new List<string>() { "@id" }, new List<object>() { producto.ID })[0];
                        producto.Imagen = productoEncontrado.Imagen;
                        producto.Marca = productoEncontrado.Marca;
                        producto.Estilo = productoEncontrado.Estilo;
                        producto.Categoria = productoEncontrado.Categoria;
                        producto.Nombre = productoEncontrado.Nombre;
                        producto.Descripcion = productoEncontrado.Descripcion;
                        producto.Genero = productoEncontrado.Genero;
                        producto.Estatus = productoEncontrado.Estatus;
                        producto.Genero = productoEncontrado.Genero;
                        producto.Imagen_bytes = productoEncontrado.Imagen_bytes;
                        producto.Detalles = productoEncontrado.Detalles;

                        foreach(DetalleProducto detalle in producto.Detalles)
                        {
                            if (producto.detalleSeleccionado.ID == detalle.ID)
                            {
                                producto.detalleSeleccionado = detalle;
                                break;
                            }
                        }

                        comando.Parameters.Clear();
                        comando.CommandText = "select idOferta from VentasOfertas where idVentaDetalle=@idvd";
                        comando.Parameters.AddWithValue("@idvd", producto.IDVentaDetalle);
                        var idOferta = comando.ExecuteScalar();
                        if (idOferta != null)
                        {
                            Oferta oferta = new OfertasDAO().ConsultaGeneral(" where idOferta=@id", new List<string>() { "@id" }, new List<object>() { idOferta })[0];
                            producto.Oferta = oferta;
                        }
                    }
                }catch(Exception ex)
                {
                    throw new Exception("Error con la BD" + ex.Message);
                }
            }
            return productos;
        }
    }
}
