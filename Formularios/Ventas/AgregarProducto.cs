using ERP_ventas.Datos;
using ERP_ventas.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace ERP_ventas.Formularios.Ventas
{
    public partial class AgregarProducto : Form
    {
        private ProductoDAO productoDAO;
        private List<Producto> productos;
        internal Producto productoSeleccionado;
        public AgregarProducto()
        {
            InitializeComponent();
            productoDAO = new ProductoDAO();
            productoSeleccionado = null;
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            try
            {
                CargarProductos();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
                Close();
            }
        }

        private void CargarProductos()
        {
            productos = productoDAO.consultaGeneral("", new List<string>(), new List<object>());
            productoComboBox.DataSource = productos;
            productoComboBox.DisplayMember = "NombreProducto";
            productoComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            productoComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void productoComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            productoSeleccionado = (Producto)productoComboBox.SelectedItem;
            fotoPictureBox.Image = new Bitmap(new MemoryStream(productoSeleccionado.Imagen_bytes));
            precioTextBox.Text = productoSeleccionado.Precio_venta.ToString("C2");
            caracteristicasTextBox.Text = string.Format("Descripcion: {0}" +
                                                        "{1}Género: {2}" +
                                                        "{1}Estilo: {3}" +
                                                        "{1}Categoría: {4}",
                                                        productoSeleccionado.Descripcion,
                                                        Environment.NewLine,
                                                        productoSeleccionado.GeneroString,
                                                        productoSeleccionado.Estilo,
                                                        productoSeleccionado.Categoria);


            Dictionary<double, DetalleProducto> tallas = new Dictionary<double, DetalleProducto>();

            foreach (DetalleProducto detalle in productoSeleccionado.Detalles)
            {
                if (!tallas.ContainsKey(detalle.Talla))
                {
                    tallas.Add(detalle.Talla, detalle);
                }
            }
            tallasComboBox.DataSource = tallas.Values.ToList();
            tallasComboBox.DisplayMember = "Talla";
            tallasComboBox.ValueMember = "Talla";
            cantidadNumericUpDown.Maximum = 1;
            existenciasTextBox.Text = "No disponible";
        }

        private void tallasComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            coloresComboBox.Items.Clear();
            existenciasTextBox.Text = "";
            double talla = (double)tallasComboBox.SelectedValue;
            foreach (DetalleProducto detalle in productoSeleccionado.Detalles)
            {
                if (detalle.Talla == talla)
                {
                    coloresComboBox.Items.Add(detalle);
                }
            }
            coloresComboBox.DisplayMember = "Color";

            cantidadNumericUpDown.Maximum = 1;
            existenciasTextBox.Text = "No disponible";
        }

        private void coloresComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DetalleProducto detalleSeleccionado = coloresComboBox.SelectedItem as DetalleProducto;
            existenciasTextBox.Text = detalleSeleccionado.Existencias.ToString();
            cantidadNumericUpDown.Maximum = detalleSeleccionado.Existencias;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                productoSeleccionado.detalleSeleccionado = coloresComboBox.SelectedItem as DetalleProducto;
                productoSeleccionado.Cantidad = (int)cantidadNumericUpDown.Value;
                FormClosing -= AgregarProducto_FormClosing;
                Close();
            }
        }

        private bool Validar()
        {
            if (productoComboBox.SelectedItem != null)
            {
                if (tallasComboBox.SelectedItem != null)
                {
                    if (coloresComboBox.SelectedItem != null)
                    {
                        if ((coloresComboBox.SelectedItem as DetalleProducto).Existencias>=cantidadNumericUpDown.Value)
                        {
                            return true;
                        }
                        else
                        {
                            Mensajes.Info("La cantidad seleccionada es inválida");
                            return false;
                        }
                    }
                    else
                    {
                        Mensajes.Info("Selecciona un color de la lista");
                        return false;
                    }
                }
                else
                {
                    Mensajes.Info("Selecciona una talla de la lista");
                    return false;

                }
            }
            else
            {
                Mensajes.Info("Selecciona un producto de la lista");
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AgregarProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            productoSeleccionado = null;
        }
    }
}
