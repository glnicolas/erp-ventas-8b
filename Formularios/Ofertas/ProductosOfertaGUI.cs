using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP_ventas.Datos;
using ERP_ventas.Modelo;

namespace ERP_ventas.Formularios.Ofertas
{
    public partial class ProductosOfertaGUI : Form
    {
        private int ID_Oferta;
        private ProductoDAO productoDAO = new ProductoDAO();
        private ProductosOfertaDAO productosOfertaDAO = new ProductosOfertaDAO();
        public ProductosOfertaGUI(int id_oferta, string nombre)
        {
            InitializeComponent();
            ID_Oferta = id_oferta;
            labelOferta.Text = nombre;
        }

        private void ProductosOfertaGUI_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxProductos.MostrarProductos(productoDAO.consultaGeneral("", new List<string>(), new List<object>()).ToArray());
                llenarProductos(productosOfertaDAO.ConsultaGeneral(" where idoferta=@id", new List<string>() { "@id" }, new List<object>() { ID_Oferta }));
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void agregarProductoATabla(Producto producto)
        {
            DataGridViewRow renglon = new DataGridViewRow();
            renglon.CreateCells(dataGridViewProductos);
            renglon.Cells[0].Value = producto.ID;
            renglon.Cells[1].Value = producto.Imagen;
            renglon.Cells[2].Value = producto.Marca;
            renglon.Cells[3].Value = producto.Nombre;
            renglon.Cells[4].Value = 'A';
            renglon.Cells[5].Value = false;
            dataGridViewProductos.Rows.Add(renglon);
        }

        private void llenarProductos(List<Producto> productos)
        {
            foreach (Producto producto in productos)
            {
                DataGridViewRow renglon = new DataGridViewRow();
                renglon.CreateCells(dataGridViewProductos);
                renglon.Cells[0].Value = producto.ID;
                renglon.Cells[1].Value = producto.Imagen;
                renglon.Cells[2].Value = producto.Marca;
                renglon.Cells[3].Value = producto.Nombre;
                renglon.Cells[4].Value = producto.Estatus;
                renglon.Cells[5].Value = true;
                if (producto.Estatus == 'I')
                    renglon.Visible = false;
                dataGridViewProductos.Rows.Add(renglon);
            }
        }

        private void dataGridViewProductos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dataGridViewProductos.Rows[e.RowIndex].Height = 100;
        }

        private void comboBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Producto item = (Producto)comboBoxProductos.SelectedItem;
            DataGridViewRow renglon = buscarProductoenTabla(item.ID);
            if (renglon == null)
                agregarProductoATabla(item);
            else
            {
                if ((char)renglon.Cells["Estatus"].Value == 'I')
                {
                    renglon.Cells["Estatus"].Value = 'A';
                    renglon.Visible = true;
                }
                else
                    Mensajes.Info("El producto " + item.NombreProducto + " ya se agregó a la oferta");
            }
        }

        private DataGridViewRow buscarProductoenTabla(int item_ID)
        {
            foreach (DataGridViewRow renglon in dataGridViewProductos.Rows)
            {
                if (item_ID == (int)renglon.Cells["ID"].Value)
                {
                    return renglon;
                }
            }
            return null;
        }

        private void dataGridViewProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DialogResult respuesta = Mensajes.PreguntaAdvertencia("¿Estás seguro de que quieres eliminar el producto seleccionado?");
                if (respuesta == DialogResult.OK)
                {
                    DataGridViewRow renglon = dataGridViewProductos.Rows[e.RowIndex];
                    if ((bool)renglon.Cells["Agregado"].Value == false)
                    {
                        dataGridViewProductos.Rows.Remove(renglon);
                    }
                    else
                    {
                        renglon.Cells["Estatus"].Value = 'I';
                        renglon.Visible = false;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProductosOfertaGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = Mensajes.PreguntaAdvertencia("Estás a punto de cerrar la ventana." +
                "\n Los cambios realizados no se guardarán. \n¿Deseas continuar?");
            if (resultado == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.Rows.Count > 0)
            {
                try
                {
                    List<Producto> productos = new List<Producto>();
                    foreach (DataGridViewRow renglon in dataGridViewProductos.Rows)
                    {
                        productos.Add(new Producto()
                        {
                            ID = (int)renglon.Cells["ID"].Value,
                            Estatus = (char)renglon.Cells["Estatus"].Value,
                            Agregado = (bool)renglon.Cells["Agregado"].Value
                        });
                    }
                    if (productosOfertaDAO.Agregar(ID_Oferta, productos))
                    {
                        Mensajes.Info("Productos agregados con éxito.");
                        FormClosing -= ProductosOfertaGUI_FormClosing; // Unsubscribe o sea, desvincula el método que muestra el diálogo de cancelar
                        Close(); //Cierra la ventana
                    }
                    else
                        Mensajes.Error("Error desconocido");
                }
                catch (Exception ex)
                {
                    Mensajes.Error(ex.Message);
                }
            }
            else
                Mensajes.Info("Agrega por lo menos un producto a la oferta");

           
        }
    }
}
