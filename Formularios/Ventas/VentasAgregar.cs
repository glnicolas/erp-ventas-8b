using ERP_ventas.Datos;
using ERP_ventas.Formularios.Clientes;
using ERP_ventas.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_ventas.Formularios.Ventas
{
    public partial class VentasAgregar : Form
    {
        private Empleado empleado;

        /*
         * Las ventas tienen 3 status:
         *  En captura
         *  Completado
         *  Pagado
         */
        private char tipoCliente;
        private object cliente ;
        private List<Producto> productos;
        public VentasAgregar()
        {
            InitializeComponent();
            cliente = null;
            productos = new List<Producto>();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click_1(object sender, EventArgs e)
        {
            BuscarClientesForm buscar = new BuscarClientesForm(cliente, tipoCliente);
            buscar.ShowDialog();
            if (buscar.cliente != null)
            {
                cliente = buscar.cliente;
                tipoCliente = buscar.tipoCliente;
                if (tipoCliente == 'I')
                    textBox1.Text = (cliente as ClienteIndividual).Nombre+" "
                        + (cliente as ClienteIndividual).Apaterno + " " + (cliente as ClienteIndividual).Amaterno;
                else
                    textBox1.Text = "Tienda: "+ (cliente as ClienteTienda).Nombre+": "+(cliente as ClienteTienda).Nombre;
            }
            else
                Mensajes.Info("Operación cancelada");
        }

        private void VentasAgregar_Load(object sender, EventArgs e)
        {
            comboBoxEstatus.SelectedIndex = 0;
            dataGridViewProductos.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;
            try
            {
                cargarVendedores();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
                Mensajes.Error("La interfaz no pudo cargarse");
                Close();
            }
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
            List<VistaProducto> vistaProductos = new List<VistaProducto>();
            foreach(Producto producto in productos)
            {
                vistaProductos.Add(new VistaProducto(producto));
            }

            dataGridViewProductos.DataSource = vistaProductos;
        }
    }
}
