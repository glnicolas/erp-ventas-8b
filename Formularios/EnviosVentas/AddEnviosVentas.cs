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
            int idVenta = (int)numericUpDown1.Value;
            int idEnvio = ((Modelo.Envios)comboBox1.SelectedItem).idenvio;
            Modelo.EnviosVentas enviosVentas = new Modelo.EnviosVentas(idEnvio, idVenta, dateTimePicker1.Value, dateTimePicker2.Value, 'A');
            var resultado = new EnviosVentaDAO().Registrar(enviosVentas);
            Type resultadoTipo = resultado.GetType();
            if (resultadoTipo.Equals(typeof(string)))
            {
                Mensajes.Error(resultado.ToString());
            }
            else 
            {
                Mensajes.Info("Registro exitoso");
                Close();
            }
        }

        private void AddEnviosVentas_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new EnviosDAO().ConsultaGeneral(" where estatus='A'", new List<string>(), new List<object>()).ToArray());
            comboBox1.DisplayMember = "idEnvio";
            comboBox2.Items.Add(new EnviosDAO().ConsultaGeneral(" where estatus='A'", new List<string>(), new List<object>()));
            comboBox2.DisplayMember = "fechaSalida";
            if (enviosVentas != null)
            {
                for (int i = 0; i < comboBox1.Items.Count; i++)
                {
                    comboBox1.SelectedIndex = i;
                }

                for (int i = 0; i < comboBox2.Items.Count; i++)
                {
                    comboBox2.SelectedIndex = i;
                }

            }
            else
            {
                numericUpDown1.Value = idVenta;
                for (int i = 0; i < comboBox1.Items.Count; i++)
                {
                    comboBox1.SelectedIndex = 0;
                }
                for (int i = 0; i < comboBox2.Items.Count; i++) 
                {
                    comboBox2.SelectedIndex = comboBox1.SelectedIndex;
                }
            }
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            int idEnvio = ((Modelo.Envios)comboBox1.SelectedItem).idenvio;
            Modelo.EnviosVentas enviosVentas = new Modelo.EnviosVentas((int)numericUpDown1.Value, idEnvio, dateTimePicker1.Value, dateTimePicker2.Value, 'A');
            var resultado = new EnviosVentaDAO().Editar(enviosVentas);
            Type resultado_tipo = resultado.GetType();

            if (resultado_tipo.Equals(typeof(string)))
            {
                Mensajes.Error(resultado.ToString());
            }
            else 
            {
                Mensajes.Info("Actualización exitosa");
                Close();
            }
        }
    }
}
