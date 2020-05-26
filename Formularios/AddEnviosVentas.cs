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
        DateTime fecha;

        public AddEnviosVentas(int idVenta,DateTime fecha) 
        {
            InitializeComponent();
            btnRegistrar.Visible = true;
            modificarBtn.Visible = false;
            this.idVenta = idVenta;
            this.fecha = fecha;
        }

        public AddEnviosVentas(Modelo.EnviosVentas enviosVentas)
        {
            InitializeComponent();
            btnRegistrar.Visible = false;
            modificarBtn.Visible = true;
            this.enviosVentas = enviosVentas;
            numericUpDown1.Value=enviosVentas.idVenta;
            comboBox1.SelectedItem = enviosVentas.idEnvio;
            dateTimePicker1.Value = enviosVentas.fechaEntregaPlaneada;
            dateTimePicker2.Value = enviosVentas.fechaEntregaReal;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            EnviosVentaDAO envdao= new EnviosVentaDAO();
            string sql_where = " where idVenta = @idVenta";
            List<string> parametros = new List<string>();
            List<object> valores = new List<object>();
            parametros.Add("@idVenta");
            valores.Add((int)numericUpDown1.Value);
            List<Modelo.EnviosVentas> enviosVentas = envdao.ConsultaGeneral(sql_where, parametros, valores);

            if (enviosVentas.Count==0)
            {
                int idVenta = (int)numericUpDown1.Value;
                int idEnvio = ((Modelo.Envios)comboBox1.SelectedItem).idenvio;
                Modelo.EnviosVentas enviosVenta = new Modelo.EnviosVentas(idEnvio, idVenta, dateTimePicker1.Value, dateTimePicker2.Value, 'A');
                var resultado = new EnviosVentaDAO().Registrar(enviosVenta);
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
            else
            {
                Mensajes.Error("El idVenta esta repetido");
            }
            
        }

        private void AddEnviosVentas_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new EnviosDAO().ConsultaGeneral(" where estatus='A'", new List<string>(), new List<object>()).ToArray());
            comboBox1.DisplayMember = "idEnvio";
            comboBox2.Items.Add(new EnviosDAO().ConsultaGeneral(" where estatus='A'", new List<string>(), new List<object>()));
            comboBox2.DisplayMember = "fechaSalida";
            comboBox2.Items.Add(fecha);
            dateTimePicker1.MinDate = (DateTime)fecha;
            dateTimePicker2.MinDate = (DateTime)fecha;
            if (enviosVentas != null)
            {
                for (int i = 0; i < comboBox1.Items.Count; i++)
                {
                    comboBox1.SelectedIndex = i;
                    if (((Modelo.Envios)comboBox1.SelectedItem).idenvio == enviosVentas.idEnvio)
                    {
                        break;
                    }
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
            Modelo.EnviosVentas enviosVentas = new Modelo.EnviosVentas(idEnvio, (int)numericUpDown1.Value, dateTimePicker1.Value, dateTimePicker2.Value, 'A');
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
