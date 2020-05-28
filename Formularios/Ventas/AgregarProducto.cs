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
using ERP_ventas.Formularios.Ofertas;

namespace ERP_ventas.Formularios.Ventas
{
    public partial class AgregarProducto : Form
    {
        private ProductoDAO productoDAO;
        private List<Producto> productos;
        internal Producto productoSeleccionado;
        internal Oferta ofertaSeleccionada;
        private Producto prod;
        public double precioreal=0;

        public AgregarProducto()
        {
            InitializeComponent();
            productoDAO = new ProductoDAO();
            productoSeleccionado = null;
            ofertaSeleccionada = null;
        }

        public AgregarProducto(VistaProducto producto)
        {
            InitializeComponent();
            productoDAO = new ProductoDAO();
            productoSeleccionado = producto.GetProducto();
            ofertaSeleccionada = producto.GetProducto().Oferta;
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            try
            {
                CargarProductos();
                if (productoSeleccionado != null)
                {
                    cargarProducto();
                    
                }
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
                Close();
            }
        }

        private void cargarProducto()
        {
            tallasComboBox.SelectedIndexChanged -= tallasComboBox_SelectedIndexChanged;
            coloresComboBox.SelectedIndexChanged -= coloresComboBox_SelectedIndexChanged;
            ofertaSeleccionada = productoSeleccionado.Oferta;
            
            foreach (Producto producto in productoComboBox.Items)
            {
                if (producto.ID == productoSeleccionado.ID)
                {
                    productoComboBox.SelectedItem = producto;
                    break;
                }
            }
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
            tallasComboBox.SelectedItem = productoSeleccionado.detalleSeleccionado;

            //Llenar colores
            double talla = (double)tallasComboBox.SelectedValue;
            foreach (DetalleProducto detalle in productoSeleccionado.Detalles)
            {
                if (detalle.Talla == talla)
                {
                    coloresComboBox.Items.Add(detalle);
                }
            }
            coloresComboBox.DisplayMember = "Color";
            coloresComboBox.SelectedItem = productoSeleccionado.detalleSeleccionado;

            existenciasTextBox.Text = productoSeleccionado.detalleSeleccionado.Existencias.ToString();
            cantidadNumericUpDown.Maximum = productoSeleccionado.detalleSeleccionado.Existencias+productoSeleccionado.Cantidad;
            
            //if (ofertaSeleccionada != null)
              //  cantidadNumericUpDown.Minimum = productoSeleccionado.Oferta.canMinProducto;
            //else
                cantidadNumericUpDown.Minimum = 1;
            cantidadNumericUpDown.Value = productoSeleccionado.Cantidad;
            coloresComboBox.SelectedItem = productoSeleccionado.detalleSeleccionado;
            VerificarOfertas();

            tallasComboBox.SelectedIndexChanged += tallasComboBox_SelectedIndexChanged;
            coloresComboBox.SelectedIndexChanged += coloresComboBox_SelectedIndexChanged;
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
            coloresComboBox.Items.Clear();
            productoSeleccionado = (Producto)productoComboBox.SelectedItem;
            precioreal=productoSeleccionado.Precio_venta;
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
            tallasComboBox.DisplayMember = "Talla";
            tallasComboBox.ValueMember = "Talla";
            tallasComboBox.DataSource = tallas.Values.ToList();
            //tallasComboBox.DisplayMember = "Talla";
            //tallasComboBox.ValueMember = "Talla";
            cantidadNumericUpDown.Maximum = 1;
            existenciasTextBox.Text = "No disponible";

            VerificarOfertas();
        }

        private void VerificarOfertas()
        {
            try
            {
                List<Oferta> ofertas = new ProductosOfertaDAO().BuscarOfertaProducto(productoSeleccionado.ID);
                if (ofertas.Count > 0)
                {
                    comboBox1.Items.Clear();
                    for (int i=0;i< ofertas.Count;i++)
                    {
                        if (cantidadNumericUpDown.Value>=ofertas[i].canMinProducto)
                        {
                            comboBox1.Items.Add(ofertas[i].OfertaString);
                            if (ofertaSeleccionada.nombre == ofertas[i].nombre)
                            {
                                comboBox1.SelectedIndex = i;
                            }
                        }
                    }
                    if (ofertaSeleccionada != null)
                    {
                        comboBox1.SelectedItem = comboBox1.FindString(ofertaSeleccionada.nombre);
                    }
                    /*
                    BuscarOfertasForm buscar = new BuscarOfertasForm(ofertas);
                    buscar.ShowDialog();
                    if (ofertaSeleccionada == null)
                    {
                        if (buscar.oferta != null)
                        {
                            SeleccionarOferta(buscar.oferta);
                        }
                        else
                        {
                            ofertaSeleccionada = null;
                            cantidadNumericUpDown.Minimum = 1;
                        }
                    }
                    else
                    {
                        if (buscar.oferta != null)
                        {
                            productoSeleccionado.Precio_venta = productoDAO.consultaGeneral(" where ID=@id", new List<string>() { "@id" }, new List<object>() { productoSeleccionado.ID })[0].Precio_venta;
                            SeleccionarOferta(buscar.oferta);
                        }
                    }*/


                }
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void tallasComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //coloresComboBox.Items.Clear();
            //existenciasTextBox.Text = "";
            //double talla = (double)tallasComboBox.SelectedValue;
            //foreach (DetalleProducto detalle in productoSeleccionado.Detalles)
            //{
            //    if (detalle.Talla == talla)
            //    {
            //        coloresComboBox.Items.Add(detalle);
            //    }
            //}
            //coloresComboBox.DisplayMember = "Color";

            //cantidadNumericUpDown.Maximum = 1;
            //existenciasTextBox.Text = "No disponible";
        }

        private void coloresComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                productoSeleccionado.Oferta = ofertaSeleccionada;
                productoSeleccionado.detalleSeleccionado = coloresComboBox.SelectedItem as DetalleProducto;
                productoSeleccionado.Cantidad = (int)cantidadNumericUpDown.Value;
                if (productoDAO.ActualizarExistencias(productoSeleccionado.detalleSeleccionado.ID, -productoSeleccionado.Cantidad))
                {
                    FormClosing -= AgregarProducto_FormClosing;
                    Close();
                }
                else
                {
                    Mensajes.Error("No se ha podido actualizar las existencias");
                }
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
                        if ((coloresComboBox.SelectedItem as DetalleProducto).Existencias != 0)
                        {
                            if ((coloresComboBox.SelectedItem as DetalleProducto).Existencias >= cantidadNumericUpDown.Value)
                            {
                                return true;
                            }
                            else
                            {
                                Mensajes.Info("La cantidad seleccionada excede las existencias");
                                return false;
                            }
                        }
                        else
                        {
                            Mensajes.Info("Se agotaron las existencias");
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

        private void coloresComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetalleProducto detalleSeleccionado = coloresComboBox.SelectedItem as DetalleProducto;
            existenciasTextBox.Text = detalleSeleccionado.Existencias.ToString();
            cantidadNumericUpDown.Maximum = detalleSeleccionado.Existencias;
           
        }

        private void SeleccionarOferta(Oferta oferta)
        {
            ofertaSeleccionada = oferta;
                if (precioreal > 0 || ofertaSeleccionada.nombre != oferta.nombre)
                {
                    productoSeleccionado.Precio_venta = (precioreal - (ofertaSeleccionada.porDescuento * precioreal));
                    precioTextBox.Text = productoSeleccionado.Precio_venta.ToString("C2");
                }
                else {
                    productoSeleccionado.Precio_venta -= ofertaSeleccionada.porDescuento * productoSeleccionado.Precio_venta;
                    precioTextBox.Text = productoSeleccionado.Precio_venta.ToString("C2");
                }
            
        }

        private void tallasComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            coloresComboBox.Items.Clear();
            existenciasTextBox.Text = "";
            double talla = (double)tallasComboBox.SelectedValue;
            coloresComboBox.DisplayMember = "Color";
            foreach (DetalleProducto detalle in productoSeleccionado.Detalles)
            {
                if (detalle.Talla == talla)
                {
                    coloresComboBox.Items.Add(detalle);
                }
            }
            cantidadNumericUpDown.Maximum = 1;
            existenciasTextBox.Text = "No disponible";
        }

        private void productoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cantidadNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            string selectantiguo = "";
            if (comboBox1.SelectedItem != null) { selectantiguo = comboBox1.SelectedItem.ToString(); }
            comboBox1.Items.Clear();
            List<Oferta> ofertas = new ProductosOfertaDAO().BuscarOfertaProducto(productoSeleccionado.ID);
            if (ofertas.Count > 0)
            {
                for (int i = 0; i < ofertas.Count; i++)
                {
                    if (cantidadNumericUpDown.Value >= ofertas[i].canMinProducto)
                    {
                        comboBox1.Items.Add(ofertas[i].OfertaString);
                        if (selectantiguo==ofertas[i].OfertaString)
                        {
                            comboBox1.SelectedItem = i;
                        }
                    }
                    if (comboBox1.Items.Count == 0)
                    {
                        productoSeleccionado.Precio_venta = precioreal;
                        precioTextBox.Text = productoSeleccionado.Precio_venta.ToString("C2");
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] result;
            try
            {
                if (comboBox1.SelectedItem != null)
                {
                    result=comboBox1.SelectedItem.ToString().Split();
                    List<Oferta> ofertas = new ProductosOfertaDAO().BuscarOfertaProducto(productoSeleccionado.ID);
                    for(int i = 0; i < ofertas.Count; i++)
                    {
                        if (result[0]==ofertas[i].idOferta.ToString())
                        {
                            SeleccionarOferta(ofertas[i]);
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex+"no se pudo seleccionar la oferta");
            }
        }
    }
}
