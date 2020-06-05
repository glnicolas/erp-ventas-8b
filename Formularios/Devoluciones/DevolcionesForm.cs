using System;
using ERP_ventas.Datos;
using ERP_ventas.Modelo;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_ventas.Formularios.Devoluciones
{
    public partial class DevolcionesForm : Form
    {
        DevolucionesDAO devolucionesDAO;
        public DevolcionesForm()
        {
            devolucionesDAO = new DevolucionesDAO();
            InitializeComponent();
        }

        private void dataVentas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn i in dataDevo.Columns) 
            {
                i.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            dataDevo.AutoResizeColumns();
        }

        private void actualizarTabla() 
        {
            devolucionesDAO.actual_page = 0;
            devolucionesDAO.CalculatePages();
            if (devolucionesDAO.pages > 1)
            {
                anteriorBtn.Enabled = false;
                siguienteBtn.Enabled = true;
            }
            else
            {
                anteriorBtn.Enabled = false;
                siguienteBtn.Enabled = false;
            }
            dataDevo.DataSource = devolucionesDAO.getNextPage();
            paginaxdey.Text = devolucionesDAO.actual_page + "  de  " + devolucionesDAO.pages;
        }

        private void DevolcionesForm_Load(object sender, EventArgs e)
        {
            elementosPaginacionCmb.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void anteriorBtn_Click(object sender, EventArgs e)
        {

            siguienteBtn.Enabled = true; //Al presionar sobre anterior, se habilita siguiente
            if (devolucionesDAO.actual_page > 1)
            {
                dataDevo.DataSource = devolucionesDAO.getPreviousPage();
            }
            if (devolucionesDAO.actual_page == 1)
            {
                anteriorBtn.Enabled = false; //Deshabilita anterior porque está en la primer página
            }
            paginaxdey.Text = devolucionesDAO.actual_page + "  de  " + devolucionesDAO.pages;
        }

        private void siguienteBtn_Click(object sender, EventArgs e)
        {
            anteriorBtn.Enabled = true; //Al presionar sobre siguiente, se habilita anterior
            if (devolucionesDAO.actual_page < devolucionesDAO.pages)
            {
                dataDevo.DataSource = devolucionesDAO.getNextPage();
            }
            if (devolucionesDAO.actual_page == devolucionesDAO.pages)
            {
                siguienteBtn.Enabled = false; //Deshabilita siguiente porque está en la última página
            }
            paginaxdey.Text = devolucionesDAO.actual_page + "  de  " + devolucionesDAO.pages;
        }

        private void elementosPaginacionCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                devolucionesDAO.rows_per_page = Convert.ToInt32(elementosPaginacionCmb.SelectedItem);
                actualizarTabla();
            }
            catch (Exception ex)
            {
                Mensajes.Error("Ha ocurrido un error. Contacta al administrador. \n" + ex.Message);
            }
        }
    }
}
