using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_ventas.Formularios
{
    public partial class submenuEnvios : Form
    {
        public submenuEnvios()
        {
            InitializeComponent();
        }

        private void btnClienteTienda_Click(object sender, EventArgs e)
        {
            Envios.Envios env = new Envios.Envios();
            env.ShowDialog();
        }

        private void btnClienteIndividual_Click(object sender, EventArgs e)
        {
            Tripulacion.TripulacionForm trip = new Tripulacion.TripulacionForm();
            trip.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
