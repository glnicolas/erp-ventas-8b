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
            Usuario user = JsonConvert.DeserializeObject<Usuario>(Properties.Settings.Default.usuarioJSON);
            lblUsuario.Text = "Bienvenido, "+user.Nombre;
            prueba();
        }

        private void prueba()
        {
            SqlConnection conexion = new SqlConnection("Data Source=localhost;Initial Catalog=ERP2020;Persist Security Info=True;User ID=sa; Password=Hola.123_");//Properties.Settings.Default.ConBD);
            conexion.Open();

            SqlCommand comando = new SqlCommand("select fotografia from Empleados where idEmpleado=1");
            comando.Connection = conexion;

            var reader = comando.ExecuteReader();
            byte[] imagebytes;
            Bitmap bitmap = null;
            while (reader.Read())
            {
                imagebytes = (byte[])reader["fotografia"];
                bitmap = new Bitmap(new MemoryStream(imagebytes));
            }

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            if (bitmap != null)
                pictureBox1.Image = bitmap;
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
            //lblFechaHora.Text = DateTime.Today.TimeOfDay.ToString();
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            SubMClientes subClientes = new SubMClientes();
            subClientes.ShowDialog();
        }
    }
}
