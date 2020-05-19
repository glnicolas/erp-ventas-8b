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

namespace ERP_ventas.Formularios.EnviosVentas
{
    public partial class EnviosVentasForm : Form
    {
        EnviosVentaDAO envdao;
        public EnviosVentasForm()
        { 
            InitializeComponent();
            try
            {
                envdao = new EnviosVentaDAO();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void EnviosVentasForm_Load(object sender, EventArgs e)
        {
            elementosPaginacionCmb.SelectedIndex = 0;
        }

        private void anteriorBtn_Click(object sender, EventArgs e)
        {
            siguienteBtn.Enabled = true; //Al presionar sobre anterior, se habilita siguiente
            if (envdao.actual_page > 1)
            {
                dataEnviosVentas.DataSource = envdao.getPreviousPage();
            }
            if (envdao.actual_page == 1)
            {
                anteriorBtn.Enabled = false; //Deshabilita anterior porque está en la primer página
            }
            paginaxdey.Text = envdao.actual_page + "  de  " + envdao.pages;
        }

        private void siguienteBtn_Click(object sender, EventArgs e)
        {
            anteriorBtn.Enabled = true;
            if (envdao.actual_page < envdao.pages)
            {
                dataEnviosVentas.DataSource = envdao.getNextPage();
            }
            if (envdao.actual_page == envdao.pages)
            {
                siguienteBtn.Enabled = false;
            }
            paginaxdey.Text = envdao.actual_page + " de " + envdao.pages;
        }

        private void buscartextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var dataTable = (DataTable)dataEnviosVentas.DataSource;
                var rows = dataTable.Select(string.Format("[Estatus] LIKE '%{0}%'",
                                                          buscartextBox.Text));
                if (rows.Count() != 0)
                    dataEnviosVentas.DataSource = rows.CopyToDataTable();
                else
                    Mensajes.Info("No se han encontrado resultados");
                dataEnviosVentas.Refresh();

            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataEnviosVentas.SelectedRows.Count != 0)
            {
                DialogResult respuesta = Mensajes.PreguntaAdvertencia("¿Estás seguro de que quieres eliminar el Envio seleccionado?");
                if (respuesta == DialogResult.OK)
                {
                    try
                    {
                        DataGridViewRow renglon = dataEnviosVentas.SelectedRows[0];
                        envdao.Eliminar((int)renglon.Cells["idVenta"].Value);
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
            envdao.actual_page = 0;
            envdao.CalculatePages();
            if (envdao.pages > 1)
            {
                anteriorBtn.Enabled = false;
                siguienteBtn.Enabled = true;
            }
            else
            {
                anteriorBtn.Enabled = false;
                siguienteBtn.Enabled = false;
            }
            dataEnviosVentas.DataSource = envdao.getNextPage();
            paginaxdey.Text = envdao.actual_page + "  de  " + envdao.pages;
        }

        private void elementosPaginacionCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                envdao.rows_per_page = Convert.ToInt32(elementosPaginacionCmb.SelectedItem);
                actualizarTabla();
            }
            catch (Exception ex)
            {
                Mensajes.Error("Ha ocurrido un error. Contacta al administrador. \n" + ex.Message);
            }
        }

        private void limpiarbutton_Click(object sender, EventArgs e)
        {
            buscartextBox.Text = "";
            actualizarTabla();
        }
    }
}
