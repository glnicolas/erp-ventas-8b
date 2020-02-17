using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP_ventas.Datos;
using ERP_ventas.Modelo;

namespace ERP_ventas.Formularios.Envios
{
    public partial class UnidadesTransporte : Form
    {

        public UnidadesTransporte()
        {
            InitializeComponent();
            TransporteDAO TDAO = new TransporteDAO();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            AddTransporte AT = new AddTransporte();
            AT.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UnidadesTransporte_Load(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void actualizarTabla()
        {
            TransporteDAO TDAO = new TransporteDAO();
            string sql_where = " where estatus=@estatus";
            List<string> parametros = new List<string>();
            List<object> valores = new List<object>();

            parametros.Add("@estatus");
            valores.Add('A');

            llenarTabla(TDAO.ConsultaGeneral(sql_where, parametros, valores));
        }

        private void llenarTabla(List<Transporte> transportes)
        {
            foreach (Transporte transporte in transportes)
            {
                DataGridViewRow renglon = new DataGridViewRow();
                renglon.CreateCells(dataGridView1);

                renglon.Cells[0].Value = transporte.ID;
                renglon.Cells[1].Value = transporte.Placas;
                renglon.Cells[2].Value = transporte.Marca;
                renglon.Cells[3].Value = transporte.Modelo;
                renglon.Cells[4].Value = transporte.Anio;
                renglon.Cells[5].Value = transporte.Capacidad;
                //renglon.Cells[6].Value = cliente.CP;
                //renglon.Cells[7].Value = cliente.RFC;
                //renglon.Cells[8].Value = cliente.Telefono;
                //renglon.Cells[9].Value = cliente.Email;
                //renglon.Cells[10].Value = cliente.IDCiudad;

                //dataGridView1.Rows.Add(renglon);
            }
        }
    }
}