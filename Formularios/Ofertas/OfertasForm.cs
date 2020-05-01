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

namespace ERP_ventas.Formularios.Ofertas
{
    public partial class OfertasForm : Form
    {
        OfertasDAO ofertasDAO;
        public OfertasForm()
        {
            InitializeComponent();
            try
            {
                ofertasDAO = new OfertasDAO();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void Ofertas_Load(object sender, EventArgs e)
        {
            elementosPaginacionCmb.SelectedIndex = 0;
        }

        private void dataOfertas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn i in dataOfertas.Columns)
            {
                i.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            dataOfertas.AutoResizeColumns();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            OfertasAgregar ofertasAgregar = new OfertasAgregar();
            ofertasAgregar.ShowDialog();
            actualizarTabla();
        }

        private void actualizarTabla()
        {
            ofertasDAO.actual_page = 0;
            ofertasDAO.CalculatePages();
            if (ofertasDAO.pages > 1)
            {
                anteriorBtn.Enabled = false;
                siguienteBtn.Enabled = true;
            }
            else
            {
                anteriorBtn.Enabled = false;
                siguienteBtn.Enabled = false;
            }
            dataOfertas.DataSource = ofertasDAO.getNextPage();
            paginaxdey.Text = ofertasDAO.actual_page + "  de  " + ofertasDAO.pages;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataOfertas.SelectedRows.Count != 0)
            {
                DialogResult respuesta = Mensajes.PreguntaAdvertencia("¿Estás seguro de que quieres eliminar la oferta seleccionada?");
                if (respuesta == DialogResult.OK)
                {
                    try
                    {
                        DataGridViewRow renglon = dataOfertas.SelectedRows[0];
                        ofertasDAO.Eliminar((int)renglon.Cells["ID"].Value);
                        Mensajes.Info("Oferta eliminada");
                        actualizarTabla();
                    }
                    catch (Exception ex)
                    {
                        Mensajes.Error(ex.Message);
                    }
                }
            }
        }

        private void anteriorBtn_Click(object sender, EventArgs e)
        {
            siguienteBtn.Enabled = true; //Al presionar sobre anterior, se habilita siguiente
            if (ofertasDAO.actual_page > 1)
            {
                dataOfertas.DataSource = ofertasDAO.getPreviousPage();
            }
            if (ofertasDAO.actual_page == 1)
            {
                anteriorBtn.Enabled = false; //Deshabilita anterior porque está en la primer página
            }
            paginaxdey.Text = ofertasDAO.actual_page + "  de  " + ofertasDAO.pages;
        }

        private void siguienteBtn_Click(object sender, EventArgs e)
        {
            anteriorBtn.Enabled = true; //Al presionar sobre siguiente, se habilita anterior
            if (ofertasDAO.actual_page < ofertasDAO.pages)
            {
                dataOfertas.DataSource = ofertasDAO.getNextPage();
            }
            if (ofertasDAO.actual_page == ofertasDAO.pages)
            {
                siguienteBtn.Enabled = false; //Deshabilita siguiente porque está en la última página
            }
            paginaxdey.Text = ofertasDAO.actual_page + "  de  " + ofertasDAO.pages;
        }

        private void dataOfertas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow renglon = dataOfertas.Rows[e.RowIndex];
                string sql_where = " where idOferta=@id";
                List<string> parametros = new List<string>();
                List<object> valores = new List<object>();
                parametros.Add("@id");
                valores.Add(renglon.Cells["ID"].Value);
                Oferta oferta = ofertasDAO.ConsultaGeneral(sql_where, parametros, valores)[0];
                OfertasAgregar ofertasAgregar = new OfertasAgregar(oferta);
                ofertasAgregar.ShowDialog();
                actualizarTabla();
            }
            else
            {
                Mensajes.Error("Selecciona un registro");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataOfertas.SelectedRows.Count != 0)
            {
                DataGridViewRow renglon = dataOfertas.SelectedRows[0];
                ProductosOfertaGUI productosOfertaGUI = new ProductosOfertaGUI((int)renglon.Cells["ID"].Value, (string)renglon.Cells["nombre"].Value);
                productosOfertaGUI.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ofertasDAO.rows_per_page = Convert.ToInt32(elementosPaginacionCmb.SelectedItem);
                actualizarTabla();
            }
            catch(Exception ex)
            {
                Mensajes.Error("Ha ocurrido un error. Contacta al administrador. \n" + ex.Message);
            }
        }

        private void dataOfertas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
