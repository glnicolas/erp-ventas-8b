using ERP_ventas.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_ventas.Modelo;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ERP_ventas.Formularios.Clientes
{
    public partial class ClienteTiendaGUI : Form
    {
        ClienteDAO clienteDAO;
        ClienteTiendaDAO clienteTiendaDAO;
        public ClienteTiendaGUI()
        {
            InitializeComponent();
            clienteDAO = new ClienteDAO();
            try
            {
                clienteTiendaDAO = new ClienteTiendaDAO();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void ClienteTienda_Load(object sender, EventArgs e)
        {
            elementosPaginacionCmb.SelectedIndex = 0;
        }

        private void actualizarTabla()
        {
            clienteTiendaDAO.actual_page = 0;
            clienteTiendaDAO.CalculatePages();

            if (clienteTiendaDAO.pages > 1)
            {
                anteriorBtn.Enabled = false;
                siguienteBtn.Enabled = true;
            }
            else
            {
                anteriorBtn.Enabled = false;
                siguienteBtn.Enabled = false;
            }
            paginacionTabla.DataSource = clienteTiendaDAO.getNextPage();

            paginaxdey.Text = clienteTiendaDAO.actual_page + "  de  " + clienteTiendaDAO.pages;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClienteTiendaRegistro clienteTiendaRegistro = new ClienteTiendaRegistro();
            clienteTiendaRegistro.ShowDialog();
            actualizarTabla();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (paginacionTabla.SelectedRows.Count != 0)
            {
                DialogResult respuesta = Mensajes.PreguntaAdvertencia("¿Estás seguro de que quieres eliminar el cliente seleccionado?");
                if (respuesta == DialogResult.OK)
                {
                    try
                    {
                        DataGridViewRow renglon = paginacionTabla.SelectedRows[0];
                        clienteDAO.Eliminar((int)renglon.Cells["ID"].Value);
                        Mensajes.Info("Cliente eliminado");
                        actualizarTabla();
                    }
                    catch (Exception ex)
                    {
                        Mensajes.Error(ex.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Aplica el formato "Llenar" a todas las columnas de la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void paginacionTabla_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn i in paginacionTabla.Columns)
            {
                i.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            paginacionTabla.AutoResizeColumns();
        }

        /// <summary>
        /// Acción de editar al presionar doble clic sobre un cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void paginacionTabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow renglon = paginacionTabla.Rows[e.RowIndex];
                string sql_where = " where idcliente=@id";
                List<string> parametros = new List<string>();
                List<object> valores = new List<object>();
                parametros.Add("@id");
                valores.Add(renglon.Cells["ID"].Value);
                Cliente cliente = clienteDAO.ConsultaGeneral(sql_where, parametros, valores)[0];
                ClienteTiendaRegistro clienteTiendaRegistro = new ClienteTiendaRegistro(cliente);
                clienteTiendaRegistro.ShowDialog();
                actualizarTabla();
            }
            else
            {
                Mensajes.Error("Selecciona un registro");
            }
        }

        private void elementosPaginacionCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                clienteTiendaDAO.rows_per_page = Convert.ToInt32(elementosPaginacionCmb.SelectedItem);
                actualizarTabla();
            }
            catch (Exception ex)
            {
                Mensajes.Error("Ha ocurrido un error. Contacta al administrador. \n" + ex.Message);
            }
        }

        /// <summary>
        /// Evento que obtiene la página anterior en la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void anteriorBtn_Click(object sender, EventArgs e)
        {
            siguienteBtn.Enabled = true; //Al presionar sobre anterior, se habilita siguiente
            if (clienteTiendaDAO.actual_page > 1)
            {
                paginacionTabla.DataSource = clienteTiendaDAO.getPreviousPage();
            }
            if (clienteTiendaDAO.actual_page == 1)
            {
                anteriorBtn.Enabled = false; //Deshabilita anterior porque está en la primer página
            }
            paginaxdey.Text = clienteTiendaDAO.actual_page + "  de  " + clienteTiendaDAO.pages;
        }

        /// <summary>
        /// Evento que obtiene la página siguiente en la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void siguienteBtn_Click(object sender, EventArgs e)
        {
            anteriorBtn.Enabled = true; //Al presionar sobre siguiente, se habilita anterior
            if (clienteTiendaDAO.actual_page < clienteTiendaDAO.pages)
            {
                paginacionTabla.DataSource = clienteTiendaDAO.getNextPage();
            }
            if (clienteTiendaDAO.actual_page == clienteTiendaDAO.pages)
            {
                siguienteBtn.Enabled = false; //Deshabilita siguiente porque está en la última página
            }
            paginaxdey.Text = clienteTiendaDAO.actual_page + "  de  " + clienteTiendaDAO.pages;
        }


    }
}
