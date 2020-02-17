using ERP_ventas.Datos;
using ERP_ventas.Modelo;
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

        TransporteDAO transporteDAO;
        public UnidadesTransporte()
        {
            InitializeComponent();
            transporteDAO = new TransporteDAO();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            AddTransporte AT = new AddTransporte();
            AT.ShowDialog();
            actualizarTabla();
        }


        private void UnidadesTransporte_Load(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void actualizarTabla()
        {
            dataGridViewtransportes.Rows.Clear();
            string sql_where = " where estatus=@estatus";
            List<string> parametros = new List<string>();
            List<object> valores = new List<object>();

            parametros.Add("@estatus");
            valores.Add('A');
            llenarTabla(transporteDAO.ConsultaGeneral(sql_where, parametros, valores));
        }

        private void llenarTabla(List<Transporte> transportes)
        {
            foreach (Transporte transporte in transportes)
            {
                DataGridViewRow renglon = new DataGridViewRow();
                renglon.CreateCells(dataGridViewtransportes);

                renglon.Cells[0].Value = transporte.ID;
                renglon.Cells[1].Value = transporte.Placas;
                renglon.Cells[2].Value = transporte.Marca;
                renglon.Cells[3].Value = transporte.Modelo;
                renglon.Cells[4].Value = transporte.Anio;
                renglon.Cells[5].Value = transporte.Capacidad + " Kg";
                renglon.Cells[6].Value = transporte.Estatus;

                dataGridViewtransportes.Rows.Add(renglon);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewtransportes.SelectedRows.Count != 0)
            {
                DialogResult respuesta = Mensajes.PreguntaAdvertencia("¿Estás seguro de que quieres eliminar el transporte seleccionado?");
                if (respuesta == DialogResult.OK)
                {
                    try
                    {
                        DataGridViewRow renglon = dataGridViewtransportes.SelectedRows[0];
                        transporteDAO.Eliminar((int)renglon.Cells["ID"].Value);
                        Mensajes.Info("Transporte eliminado");
                        actualizarTabla();
                    }
                    catch (Exception ex)
                    {
                        Mensajes.Error(ex.Message);
                    }

                }

            }
        }

        private void dataGridViewtransportes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow renglon = dataGridViewtransportes.Rows[e.RowIndex];
                Transporte transporte = new Transporte(
                    (int)renglon.Cells["ID"].Value,
                    (string)renglon.Cells["Placas"].Value,
                    (string)renglon.Cells["Marca"].Value,
                    (string)renglon.Cells["Modelo"].Value,
                    (int)renglon.Cells["Anio"].Value,
                    int.Parse(renglon.Cells["Capacidad"].Value.ToString().Replace(" Kg", "")),
                    (char)renglon.Cells["Estatus"].Value
                    );
                AddTransporte AT = new AddTransporte(transporte);
                AT.ShowDialog();
                actualizarTabla();
            }
            else
            {
                Mensajes.Error("Selecciona un registro");
            }
        }
    }
}