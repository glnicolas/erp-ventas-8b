using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP_ventas.Clientes;
using ERP_ventas.Formularios.Clientes;

namespace ERP_ventas.Formularios
{
    public partial class SubMClientes : Form
    {
        public SubMClientes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClienteIndividual_Click(object sender, EventArgs e)
        {
            ClienteIndividualForm ClienteIndividual = new ClienteIndividualForm();
            ClienteIndividual.ShowDialog();
        }

        private void btnClienteTienda_Click(object sender, EventArgs e)
        {
            ClienteTienda clienteTiendaF = new ClienteTienda();
            clienteTiendaF.ShowDialog();
        }
    }
}
