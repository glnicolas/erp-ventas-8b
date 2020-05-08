using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP_ventas.Modelo;
using ERP_ventas.Datos;
using System.Windows.Forms;
using System.Data.SqlClient;
using ERP_ventas.Modelo;

namespace ERP_ventas.Formularios.Envios
{
    public partial class Envios : Form
    {

        EnviosDAO enviosDAO;
        public Envios()
        {
            InitializeComponent();
            try
            {
                enviosDAO = new EnviosDAO();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void anteriorBtn_Click(object sender, EventArgs e)
        {
            siguienteBtn.Enabled = true; //Al presionar sobre anterior, se habilita siguiente
            if (enviosDAO.actual_page > 1)
            {
                paginacionTabla.DataSource = enviosDAO.getPreviousPage();
            }
            if (enviosDAO.actual_page == 1)
            {
                anteriorBtn.Enabled = false; //Deshabilita anterior porque está en la primer página
            }
            paginaxdey.Text = enviosDAO.actual_page + "  de  " + enviosDAO.pages;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            AddEnvio AV = new AddEnvio();
            AV.ShowDialog();
            actualizarTabla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (paginacionTabla.SelectedRows.Count != 0)
            {
                DialogResult respuesta = Mensajes.PreguntaAdvertencia("¿Estás seguro de que quieres eliminar el Envio seleccionado?");
                if (respuesta == DialogResult.OK)
                {
                    try
                    {
                        DataGridViewRow renglon = paginacionTabla.SelectedRows[0];
                        enviosDAO.Eliminar((int)renglon.Cells["ID"].Value);
                        Mensajes.Info("Envio eliminado");
                        actualizarTabla();
                    }
                    catch (Exception ex)
                    {
                        Mensajes.Error(ex.Message);
                    }
                }
            }
        }

        private void actualizarTabla()
        {
            enviosDAO.actual_page = 0;
            enviosDAO.CalculatePages();
            if (enviosDAO.pages > 1)
            {
                anteriorBtn.Enabled = false;
                siguienteBtn.Enabled = true;
            }
            else
            {
                anteriorBtn.Enabled = false;
                siguienteBtn.Enabled = false;
            }
            paginacionTabla.DataSource = enviosDAO.getNextPage();
            paginaxdey.Text = enviosDAO.actual_page + "  de  " + enviosDAO.pages;
        }

        private void siguienteBtn_Click(object sender, EventArgs e)
        {
            anteriorBtn.Enabled = true;
            if (enviosDAO.actual_page < enviosDAO.pages)
            {
                paginacionTabla.DataSource = enviosDAO.getNextPage();
            }
            if (enviosDAO.actual_page == enviosDAO.pages)
            {
                siguienteBtn.Enabled = false;
            }
            paginaxdey.Text = enviosDAO.actual_page + " de " + enviosDAO.pages;
        }

        private void buscartextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var dataTable = (DataTable)paginacionTabla.DataSource;
                var rows = dataTable.Select(string.Format("[Estatus] LIKE '%{0}%'",
                                                          buscartextBox.Text));
                if (rows.Count() != 0)
                    paginacionTabla.DataSource = rows.CopyToDataTable();
                else
                    Mensajes.Info("No se han encontrado resultados");
                paginacionTabla.Refresh();

            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void limpiarbutton_Click(object sender, EventArgs e)
        {
            buscartextBox.Text = "";
            actualizarTabla();
        }

        private void paginacionTabla_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn i in paginacionTabla.Columns)
            {
                i.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            paginacionTabla.AutoResizeColumns();
        }

        private void elementosPaginacionCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                enviosDAO.rows_per_page = Convert.ToInt32(elementosPaginacionCmb.SelectedItem);
                actualizarTabla();
            }
            catch (Exception ex)
            {
                Mensajes.Error("Ha ocurrido un error. Contacta al administrador. \n" + ex.Message);
            }
        }

        private void Envios_Load_1(object sender, EventArgs e)
        {
            elementosPaginacionCmb.SelectedIndex = 0;
        }

        private void paginacionTabla_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow renglon = paginacionTabla.Rows[e.RowIndex];
                string sql_where = " where idenvio=@id";
                List<string> parametros = new List<string>();
                List<object> valores = new List<object>();
                parametros.Add("@id");
                valores.Add(renglon.Cells["ID"].Value);
                Modelo.Envios env = enviosDAO.ConsultaGeneral(sql_where, parametros, valores)[0];
                AddEnvio envgui = new AddEnvio(env);
                envgui.ShowDialog();
                actualizarTabla();
            }
            else
            {
                Mensajes.Error("Selecciona un registro");
            }
        }

        public static implicit operator Envios(Modelo.Envios v)
        {
            throw new NotImplementedException();
        }
    }
}
