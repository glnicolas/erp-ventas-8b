using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_ventas.Formularios.Envios
{
    public partial class UnidadesTransporte : Form
    {
        public UnidadesTransporte()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            AddTransporte AT = new AddTransporte();
            AT.Show();
        }

    }
}
