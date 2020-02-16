using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Windows.Forms;
using ERP_ventas.Clientes;
using ERP_ventas.Formularios.Envios;
using ERP_ventas.Modelo;
using System.Data.SqlClient;
using System.IO;
using ERP_ventas.Datos;
using ERP_ventas.Formularios;

namespace ERP_ventas
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClienteIndividualForm cli = new ClienteIndividualForm();
            cli.ShowDialog();
            
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            Usuario user = new UsuarioDAO().obtenerUsuario(Properties.Settings.Default.IDUsuario);
            lblUsuario.Text = "Bienvenido, " + user.Nombre;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = user.Empleado.Fotografia;
        }

        private void MenuPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void btnTransporte_Click(object sender, EventArgs e)
        {
            UnidadesTransporte UnTra = new UnidadesTransporte();
            UnTra.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            SubMClientes subClientes = new SubMClientes();
            subClientes.ShowDialog();
        }
    }
}
