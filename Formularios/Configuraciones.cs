using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_ventas.Formularios
{
    public partial class Configuraciones : Form
    {
        public Configuraciones()
        {
            InitializeComponent();
        }

     
        private void Configuraciones_Load(object sender, EventArgs e)
        {
            ServertextBox.Text = Properties.Settings.Default.nombreServidor;
            BDtextBox.Text = Properties.Settings.Default.nombreBD;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string cadenaCon = "Data Source=" + ServertextBox.Text + "; Initial Catalog=" + BDtextBox.Text + "; User Id=ERPUser;Password=Hola.123;";
            using (SqlConnection conexion = new SqlConnection(cadenaCon))
            {
                try
                {
                    conexion.Open();
                    if (conexion.State == ConnectionState.Open)
                    {
                        Mensajes.Info("Conexión establecida con éxito");
                    }
                    else
                    {
                        Mensajes.Info("No se pudo establecer conexión");
                    }
                }
                catch (SqlException ex)
                {
                    Mensajes.Error("Error al intentar establecer conexión. " + ex.Message);
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string cadenaCon = "Data Source=" + ServertextBox.Text + "; Initial Catalog=" + BDtextBox.Text + "; User Id=ERPUser;Password=Hola.123;";
            Properties.Settings.Default.cadenaConexion = cadenaCon;
            Properties.Settings.Default.nombreServidor = ServertextBox.Text;
            Properties.Settings.Default.nombreBD = BDtextBox.Text;
            Properties.Settings.Default.Save();
            Mensajes.Info("Ajustes guardados con éxito");
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
        }

    }
}
