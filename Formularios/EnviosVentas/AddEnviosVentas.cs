using System;
using ERP_ventas.Modelo;
using ERP_ventas.Datos;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_ventas.Formularios.EnviosVentas
{
    public partial class AddEnviosVentas : Form
    {
        Modelo.EnviosVentas enviosVentas;
        int opcion;
        int idVenta;

        public AddEnviosVentas(int idVenta) 
        {
            InitializeComponent();
            btnRegistrar.Visible = true;
            modificarBtn.Visible = false;
            this.idVenta = idVenta;
        }

        public AddEnviosVentas(Modelo.EnviosVentas enviosVentas)
        {
            InitializeComponent();
            btnRegistrar.Visible = false;
            modificarBtn.Visible = true;
            this.enviosVentas = enviosVentas;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void AddEnviosVentas_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new EnviosDAO().ConsultaGeneral("", new List<string>(), new List<object>()).ToArray());
            if (enviosVentas != null)
            {
                for (int i = 0; i < comboBox1.Items.Count; i++)
                {
                    comboBox1.SelectedIndex = i;

                }
            }
            else 
            {
                numericUpDown1.Value = idVenta;
            }
        }
    }
}
