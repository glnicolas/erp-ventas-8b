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

        public SubMClientes(int n)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            btnClienteIndividual.Click += btnClienteIndividualAgregar_Click;
            btnClienteTienda.Click += btnClienteTiendaAgregar_Click;

            btnClienteIndividual.Click -= btnClienteIndividual_Click;
            btnClienteTienda.Click -= btnClienteTienda_Click;
        }

        private void btnClienteIndividual_Click(object sender, EventArgs e)
        {
            ClienteIndividualForm ClienteIndividual = new ClienteIndividualForm();
            ClienteIndividual.ShowDialog();
        }

        private void btnClienteIndividualAgregar_Click(object sender, EventArgs e)
        {
            ClienteIndividualAgregar ClienteIndividual = new ClienteIndividualAgregar();
            ClienteIndividual.ShowDialog();
        }

        private void btnClienteTienda_Click(object sender, EventArgs e)
        {
            ClienteIndividualAgregar clienteTiendaF = new ClienteIndividualAgregar();
            clienteTiendaF.Show();
        }

        private void btnClienteTiendaAgregar_Click(object sender, EventArgs e)
        {
            ClienteTiendaRegistro clienteTiendaF = new ClienteTiendaRegistro();
            clienteTiendaF.ShowDialog();
        }

        private void SubMClientes_Load(object sender, EventArgs e)
        {
        }
    }
}
