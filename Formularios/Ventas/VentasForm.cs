using ERP_ventas.Datos;
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
    public partial class VentasForm : Form
    {
        private VentaDAO ventaDAO;
        public VentasForm()
        {
            InitializeComponent();
            ventaDAO = new VentaDAO();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            VentasAgregar ventasAgregar = new VentasAgregar();
            ventasAgregar.ShowDialog();
        }

        private void VentasForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
        }

        private void VentasForm_Load(object sender, EventArgs e)
        {
            dataOfertas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            try
            {
                dataOfertas.DataSource=ventaDAO.ConsultaGeneral("", new List<string>(), new List<object>());
            }catch(Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (dataOfertas.SelectedRows.Count == 1)
            {
                var row = dataOfertas.SelectedRows[0];
                var venta = (Venta)row.DataBoundItem; //Castea el row como objeto de la clase venta
                if (venta.EstatusChar == 'P')
                    Mensajes.Error(venta.ToString());
                else
                {
                    //Mensajes.Info("La venta seleccionada aún no se puede enviar");
                    EnviosVentas.AddEnviosVentas addEnviosVentas = new EnviosVentas.AddEnviosVentas(venta.ID);
                    addEnviosVentas.ShowDialog();
                }
            }
        }
    }
}
