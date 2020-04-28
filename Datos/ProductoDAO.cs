using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using ERP_ventas.Formularios.Ofertas;
using ERP_ventas.Modelo;

namespace ERP_ventas.Datos
{
    class ProductoDAO
    {

        public List<Producto> consultaGeneral(string sql_where, List<string> parametros, List<object> valores)
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    string cadena_sql = "select * from Productos_venta " + sql_where;
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
                                 ConsultarimagenProducto((int)lector["ID"])
                                 );
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

        internal byte[] ConsultarimagenProducto(int id)
        {
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
            {
                string comando_txt = "select imagen from ImagenesProducto where idProducto=@id and principal='P'";
                SqlCommand comando = new SqlCommand(comando_txt, conexion);
                comando.Parameters.AddWithValue("@id", id);
                conexion.Open();
                var img = comando.ExecuteScalar();
                if (img != null)
                    return (byte[])img;
                else
                    return null;
            }
        }

       

    }
}
