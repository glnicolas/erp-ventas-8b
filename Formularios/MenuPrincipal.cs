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

namespace ERP_ventas
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            //ClienteIndividual cl = new ClienteIndividual();
            //cl.Show();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClienteIndividual cli = new ClienteIndividual();
            cli.ShowDialog();
            
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Click(object sender, EventArgs e)
        {

        }
    }
}
