using ERP_ventas.Datos;
using ERP_ventas.Formularios.Clientes;
using ERP_ventas.Modelo;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_ventas.Formularios.Ventas
{
    public partial class VentasAgregar : Form
    {
        private VentaDAO ventaDAO;
        private decimal totalPagar;
        private double totalPagarD;
        private bool editar = false;

        /*
         * Las ventas tienen 3 status:
         * A: En Captura
           P: Pagado
           C: Cancelado
           F: Finalizada
         */
        private Cliente cliente;
        private List<Producto> productos;
        private Venta ventaEnCaptura;
        private double precio_venta;

        public VentasAgregar()
        {
            InitializeComponent();
            cliente = null;
            productos = new List<Producto>();
            ventaDAO = new VentaDAO();
            comboBoxEstatus.SelectedIndex = 0;
        }

        public VentasAgregar(Venta venta)
        {
            InitializeComponent();
            productos = new List<Producto>();
            ventaDAO = new VentaDAO();
            comboBoxEstatus.SelectedIndex = 0;
            ventaEnCaptura = venta;
        }

        public VentasAgregar(Venta venta, double precio_venta)
        {

        }

        private void btnBuscarCliente_Click_1(object sender, EventArgs e)
        {
            BuscarClientesForm buscar = new BuscarClientesForm();
            buscar.ShowDialog();
            if (buscar.clienteEncontrado != null)
            {
                cliente = buscar.clienteEncontrado;
                if (cliente.Tipo == 'I')
                {
                    textBox1.Text = (cliente.InfoCliente as ClienteIndividual).Nombre + " " + (cliente.InfoCliente as ClienteIndividual).Apaterno
                        + " " + (cliente.InfoCliente as ClienteIndividual).Amaterno;
                }
                else
                {
                    textBox1.Text = (cliente.InfoCliente as ClienteTienda).Contacto + ": " + (cliente.InfoCliente as ClienteTienda).Nombre;
                }
            }
            else
                Mensajes.Info("Operación cancelada");
        }
        private void VentasAgregar_Load(object sender, EventArgs e)
        {
            
            dataGridViewProductos.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;
            try
            {
                cargarVendedores();
                if (ventaEnCaptura == null)
                {
                    registrarVenta();
                    comboBoxEstatus.SelectedIndex = 0;
                }
                else
                {
                    cargarVenta();
                }
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
                Mensajes.Error("La interfaz no pudo cargarse");
                Close();
            }
        }

        private void cargarVenta()
        {
            cliente = ventaEnCaptura.ClienteObj;
            comentariosTextBox.Text = ventaEnCaptura.Comentarios;
            productos = ventaEnCaptura.Productos;
            ActualizarTablaProductos();
            label1.Text = "Editar venta";
            labelVenta.Text = string.Format("No. {0}", ventaEnCaptura.ID);
            textBox1.Text = ventaEnCaptura.Cliente;
        }

        private void registrarVenta()
        {
            ventaEnCaptura = ventaDAO.Registrar();
            //ventaEnCaptura = ventaDAO.ConsultaGeneral(" where idventa=@id", new List<string>() { "@id" }, new List<object>() { 23 })[0];
            if (ventaEnCaptura == null)
                throw new Exception("La venta no se registró correctamente.");
            else
                labelVenta.Text = "No. " + ventaEnCaptura.ID;
        }
        private void cargarVendedores()
        {
            empleadosComboBox.DataSource = new EmpleadoDAO().ConsultaGeneral("",
                new List<string>(), new List<object>());
            empleadosComboBox.DisplayMember = "Emp";
            empleadosComboBox.ValueMember = "ID";
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarProducto agregarProducto = new AgregarProducto();
            agregarProducto.ShowDialog();
            Producto producto = agregarProducto.productoSeleccionado;
            if (producto != null)
            {
                Mensajes.Info("Agregado");
                productos.Add(producto);
                ActualizarTablaProductos();
            }
            else
                Mensajes.Info("Operación cancelada");

        }
        private void ActualizarTablaProductos()
        {
            totalPagar = 0;
            totalPagarD = 0;
            List<VistaProducto> vistaProductos = new List<VistaProducto>();
            foreach (Producto producto in productos)
            {
                totalPagar += producto.Suma;
                totalPagarD += (producto.Precio_real*producto.Cantidad);
                vistaProductos.Add(new VistaProducto(producto));
            }
            totalTextBox.Text = totalPagar.ToString("C2");
            dataGridViewProductos.DataSource = vistaProductos;

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = Mensajes.PreguntaInfo("La venta se cancelará, ¿deseas continuar?");
            if (respuesta == DialogResult.OK)
            {
                try
                {
                    if (ventaDAO.Cancelar(ventaEnCaptura.ID))
                    {
                        Mensajes.Info(string.Format("La venta no. {0} ha sido cancelada", ventaEnCaptura.ID));
                        Close();
                    }
                    else
                    {
                        Mensajes.Info(string.Format("La venta no. {0} no pudo ser cancelada", ventaEnCaptura.ID));
                    }
                }
                catch (Exception ex)
                {
                    Mensajes.Error(ex.StackTrace);
                }
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.SelectedRows.Count == 1)
            {
                DialogResult resultado = Mensajes.PreguntaInfo(string.Format("¿Eliminar el producto seleccionado?"));

                if (resultado == DialogResult.OK)
                {
                    var row = dataGridViewProductos.SelectedRows[0];
                    var producto = (VistaProducto)row.DataBoundItem;
                    if (new ProductoDAO().ActualizarExistencias(producto.IDDetalle, producto.Cantidad))
                    {
                        Mensajes.Info("Producto eliminado");
                        productos.Remove(producto.GetProducto());
                        ActualizarTablaProductos();
                    }
                    else
                        Mensajes.Error("Se ha producido un error");
                }
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.SelectedRows.Count == 1)
            {
                try
                {
                    var row = dataGridViewProductos.SelectedRows[0];
                    var producto = (VistaProducto)row.DataBoundItem; //Castea el row como objeto de la clase
                    if (new ProductoDAO().ActualizarExistencias(producto.IDDetalle, producto.Cantidad))
                    {AgregarProducto agregarProducto = new AgregarProducto(producto);
                        using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                        {
                            string cadena_sql = "";
                            cadena_sql = "  select precioventa from Productos where idProducto= @idproducto";
                            SqlCommand comando = new SqlCommand(cadena_sql, conexion);
                            comando.Parameters.AddWithValue("@idproducto", producto.ID);
                            conexion.Open();

                            using (SqlDataReader reader = comando.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    agregarProducto.precioreal=(double)reader["precioventa"];
                                }
                            }
                            conexion.Close();
                        }
                        agregarProducto.ShowDialog();
                        if (agregarProducto.productoSeleccionado != null)
                        {
                            producto = new VistaProducto(agregarProducto.productoSeleccionado);
                            productos.RemoveAt(row.Index);
                            productos.Add(producto.GetProducto());
                            ActualizarTablaProductos();
                        }
                        else
                        {
                            new ProductoDAO().ActualizarExistencias(producto.IDDetalle, -producto.Cantidad);
                        }
                    }
                    else
                        Mensajes.Error("Se ha producido un error");
                }
                catch (Exception ex)
                {
                    Mensajes.Error(ex.Message);
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (empleadosComboBox.SelectedItem != null)
            {
                if (cliente != null)
                {
                    if (dataGridViewProductos.Rows.Count > 0)
                    {
                        ventaEnCaptura.EstatusChar = 'A';
                        ventaEnCaptura.TotalPagar = totalPagar;
                        ventaEnCaptura.EmpleadoObj = (Empleado)empleadosComboBox.SelectedItem;
                        ventaEnCaptura.ClienteObj = cliente;
                        ventaEnCaptura.Comentarios = comentariosTextBox.Text;
                        ventaEnCaptura.Productos = productos;
                        try
                        {
                            if(ventaDAO.Actualizar(ventaEnCaptura))
                            {
                                if (editar)
                                    Mensajes.Info("Venta actualizada");
                                else
                                    Mensajes.Info("Venta registrada");
                                Close();
                            }
                        }
                        catch(Exception ex)
                        {
                            foreach(Producto producto in productos)
                            {
                                try
                                {
                                    new ProductoDAO().ActualizarExistencias(producto.detalleSeleccionado.ID, producto.Cantidad);
                                }
                                catch(Exception en) {
                                    Mensajes.Error(en.Message);
                                }
                            }
                            Mensajes.Error(ex.Message);
                        }

                    }
                    else
                        Mensajes.Info("Agrega por lo menos un producto a la venta");
                }
                else
                    Mensajes.Info("Seleccionna un cliente");
            }
            else
                Mensajes.Info("Seleccionna un empleado");
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (empleadosComboBox.SelectedItem != null)
            {
                if (cliente != null)
                {
                    if (dataGridViewProductos.Rows.Count > 0)
                    {
                        ventaEnCaptura.EstatusChar = 'F';
                        ventaEnCaptura.TotalPagar = totalPagar;
                        ventaEnCaptura.EmpleadoObj = (Empleado)empleadosComboBox.SelectedItem;
                        ventaEnCaptura.ClienteObj = cliente;
                        ventaEnCaptura.Comentarios = comentariosTextBox.Text;
                        ventaEnCaptura.Productos = productos;
                        DialogResult respuesta = Mensajes.PreguntaInfo("¿Estás seguro que quieres finalizar la venta?\nNo se podrán realizar cambios después");
                        if (respuesta == DialogResult.OK)
                        {
                            try
                            {
                                if (ventaDAO.Actualizar(ventaEnCaptura))
                                {
                                        Mensajes.Info("Venta finalizada");
                                    Close();
                                }
                            }
                            catch (Exception ex)
                            {
                                foreach (Producto producto in productos)
                                {
                                    try
                                    {
                                        new ProductoDAO().ActualizarExistencias(producto.detalleSeleccionado.ID, producto.Cantidad);
                                    }
                                    catch (Exception en)
                                    {
                                        Mensajes.Error(en.Message);
                                    }
                                }
                                Mensajes.Error(ex.Message);
                            }
                        }
                    }
                    else
                        Mensajes.Info("Agrega por lo menos un producto a la venta");
                }
                else
                    Mensajes.Info("Seleccionna un cliente");
            }
            else
                Mensajes.Info("Seleccionna un empleado");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FacturaPDF();
        }

        private void FacturaPDF()
        {

            double fiva = Double.Parse(totalPagar.ToString()) * 0.16;
            Mensajes.Info(" " + fiva);
            if (dataGridViewProductos.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "factura.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("no es posible escribir aqui." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridViewProductos.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridViewProductos.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridViewProductos.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance("../../Resources/ZIZA.png");
                                imagen.BorderWidth = 0;
                                imagen.Alignment = Element.ALIGN_LEFT;
                                float percentage = 0.0f;
                                percentage = 150 / imagen.Width;
                                imagen.ScalePercent(percentage * 150);

                                Paragraph parrafo = new Paragraph("Orden de venta");
                                parrafo.Alignment = Element.ALIGN_RIGHT;
                                PdfDiv div = new PdfDiv();
                                div.AddElement(imagen);
                                div.AddElement(parrafo);
                                pdfDoc.Add(div);
                                pdfDoc.Add(Chunk.NEWLINE);



                                Paragraph p1 = new Paragraph("Dirección:                                                                                              Fecha: " + ventaEnCaptura.Fecha.ToString("d"));
                                pdfDoc.Add(p1);
                                p1 = new Paragraph("" + cliente.Direccion + ", " + cliente.CP);
                                pdfDoc.Add(p1);





                                string ciudadtxt = "";
                                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                                {
                                    string cadena_sql = "";
                                    cadena_sql = "  select nombre from ciudades where idciudad= @idproducto";
                                    SqlCommand comando = new SqlCommand(cadena_sql, conexion);
                                    comando.Parameters.AddWithValue("@idproducto", cliente.IDCiudad);
                                    conexion.Open();

                                    using (SqlDataReader reader = comando.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            ciudadtxt = String.Format("{0}", reader["nombre"]);
                                        }
                                    }

                                    conexion.Close();

                                }

                                p1 = new Paragraph(ciudadtxt + ", Mich.");
                                pdfDoc.Add(p1);
                                pdfDoc.Add(Chunk.NEWLINE);
                                p1 = new Paragraph("Telefono: " + cliente.Telefono + "                                                                      No de OC: " + ventaEnCaptura.ID);
                                pdfDoc.Add(p1);
                                pdfDoc.Add(Chunk.NEWLINE);
                                p1 = new Paragraph("Email: " + "atencionacliente@ziza.com" + "                                                     Atención: " + "Abraham Barriga Garibay");
                                pdfDoc.Add(p1);

                                pdfDoc.Add(Chunk.NEWLINE);
                                pdfDoc.Add(Chunk.NEWLINE);
                                p1 = new Paragraph("Numero de cliente: " + cliente.ID + "                                                                        Cliente: " + textBox1.Text);
                                pdfDoc.Add(p1);
                                pdfDoc.Add(Chunk.NEWLINE);

                                pdfDoc.Add(pdfTable);
                                pdfDoc.Add(Chunk.NEWLINE);

                                p1 = new Paragraph("   Subtotal   $" + totalPagarD.ToString() + "   ");
                                p1.Alignment = Element.ALIGN_RIGHT;
                                pdfDoc.Add(p1);



                                p1 = new Paragraph("+ IVA(16 %)    IVA incluido");
                                p1.Alignment = Element.ALIGN_RIGHT;
                                pdfDoc.Add(p1);
                                p1 = new Paragraph(" Descuento   -$" + (totalPagarD- Double.Parse(totalPagar.ToString())) + "   ");
                                p1.Alignment = Element.ALIGN_RIGHT;
                                pdfDoc.Add(p1);
                                p1 = new Paragraph("-----------------------------");
                                p1.Alignment = Element.ALIGN_RIGHT;
                                pdfDoc.Add(p1);
                                p1 = new Paragraph("     Total    $" + totalPagar.ToString() + "   ");
                                p1.Alignment = Element.ALIGN_RIGHT;
                                pdfDoc.Add(p1);

                                pdfDoc.Add(Chunk.NEWLINE);
                                pdfDoc.Add(Chunk.NEWLINE);
                                pdfDoc.Add(Chunk.NEWLINE);
                                pdfDoc.Add(Chunk.NEWLINE);
                                pdfDoc.Add(Chunk.NEWLINE);
                                pdfDoc.Add(Chunk.NEWLINE);
                                pdfDoc.Add(Chunk.NEWLINE);
                                pdfDoc.Add(Chunk.NEWLINE);

                                p1 = new Paragraph("____________________________           ");
                                p1.Alignment = Element.ALIGN_RIGHT;
                                pdfDoc.Add(p1);
                                p1 = new Paragraph("Autorizó: Abraham Barriga Garibay           ");
                                p1.Alignment = Element.ALIGN_RIGHT;
                                pdfDoc.Add(p1);
                                p1 = new Paragraph("Firma y Sello                            ");
                                p1.Alignment = Element.ALIGN_RIGHT;
                                pdfDoc.Add(p1);


                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("informacion exportada !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay que exportar !!!", "Info");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();


            foreach (DataGridViewColumn column in dataGridViewProductos.Columns)
            {
                dt.Columns.Add(column.HeaderText, column.ValueType);
            }


            foreach (DataGridViewRow row in dataGridViewProductos.Rows)
            {
                dt.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }
            }
            dt.TableName = "as";
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (dt.Rows.Count != 0)
            {
                saveFileDialog1.Filter = "XML|*.xml";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        dt.WriteXml(saveFileDialog1.FileName);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
        }
    }
}
