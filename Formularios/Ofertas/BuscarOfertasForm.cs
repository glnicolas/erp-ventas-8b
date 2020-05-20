using System;
using System.Collections.Generic;
using ERP_ventas.Modelo;
using System.Windows.Forms;

namespace ERP_ventas.Formularios.Ofertas
{
    public partial class BuscarOfertasForm : Form
    {
        internal Oferta oferta;
        public BuscarOfertasForm(List<Oferta> ofertas)
        {
            InitializeComponent();
            dataGridView1.DataSource = ofertas;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;
            oferta = null;
        }

        private void BuscarOfertasForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var row = dataGridView1.SelectedRows[0];
                oferta = (Oferta)row.DataBoundItem;

                DialogResult respuesta = Mensajes.PreguntaInfo(string.Format("¿Seleccionar la oferta {0}?", oferta.nombre));
                if (respuesta == DialogResult.OK)
                {
                    FormClosing -= BuscarOfertasForm_FormClosing;
                    Close();
                }
                else
                    oferta = null;
            }
            else
            {
                Mensajes.Info("Selecciona una oferta");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oferta = null;
            Close();
        }

        private void BuscarOfertasForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = Mensajes.PreguntaInfo(string.Format("No hay ninguna oferta seleccionada, ¿Continuar?"));

            if (resultado == DialogResult.Cancel)
                e.Cancel = true;
        }
    }
}
