using ERP_ventas.Datos;
using ERP_ventas.Formularios.Clientes;
using ERP_ventas.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_ventas.Clientes
{
    public partial class ClienteIndividualForm : Form
    {

        ClienteDAO clienteDAO;
        ClienteIndividualDAO clienteIndividual;
        public ClienteIndividualForm()
        {
            InitializeComponent();
            clienteDAO = new ClienteDAO();
            try
            {
                clienteIndividual = new ClienteIndividualDAO();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void ClienteIndividual_Load(object sender, EventArgs e)
        {
            //actualizarTabla(); //obsoleto
            try
            {
                dataGridViewClientes.DataSource = clienteIndividual.getNextPage();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }



        private void actualizarTabla()
        {
            clienteIndividual.actual_page = 0;
            clienteIndividual.CalculatePages();
            anteriorBtn.Enabled = false;
            siguienteBtn.Enabled = true;
            dataGridViewClientes.DataSource = clienteIndividual.getNextPage();
            paginaxdey.Text = clienteIndividual.actual_page + "  de  " + clienteIndividual.pages;
        }

        private void llenarTabla(List<Cliente> clientes)
        {

            //foreach (Cliente cliente in clientes)
            //{
            //    DataGridViewRow renglon = new DataGridViewRow();
            //    renglon.CreateCells(dataGridViewClientes);

            //    renglon.Cells[0].Value = cliente.ID;
            //    renglon.Cells[1].Value = ((ClienteIndividual)cliente.InfoCliente).Nombre;
            //    renglon.Cells[2].Value = ((ClienteIndividual)cliente.InfoCliente).Apaterno;
            //    renglon.Cells[3].Value = ((ClienteIndividual)cliente.InfoCliente).Amaterno;
            //    renglon.Cells[4].Value = ((ClienteIndividual)cliente.InfoCliente).Sexo;
            //    renglon.Cells[5].Value = cliente.Direccion;
            //    renglon.Cells[6].Value = cliente.CP;
            //    renglon.Cells[7].Value = cliente.RFC;
            //    renglon.Cells[8].Value = cliente.Telefono;
            //    renglon.Cells[9].Value = cliente.Email;
            //    renglon.Cells[10].Value = cliente.IDCiudad;

            //    dataGridViewClientes.Rows.Add(renglon);
            //}
        }

        private void dataGridViewClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewClientes.Rows.Count > 0)
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow renglon = dataGridViewClientes.Rows[e.RowIndex];
                    string sql_where = " where idcliente=@id";
                    List<string> parametros = new List<string>();
                    List<object> valores = new List<object>();

                    parametros.Add("@id");
                    valores.Add(renglon.Cells["ID"].Value);

                    Cliente cliente = clienteDAO.ConsultaGeneral(sql_where, parametros, valores)[0];
                    ClienteIndividualAgregar clienteIndividualAgregar = new ClienteIndividualAgregar(cliente);
                    clienteIndividualAgregar.ShowDialog();
                    actualizarTabla();
                }
                else
                {
                    Mensajes.Error("Selecciona un registro");
                }
            }
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            ClienteIndividualAgregar clienteIndividualAgregar = new ClienteIndividualAgregar();
            clienteIndividualAgregar.ShowDialog();
            actualizarTabla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count != 0)
            {
                DialogResult respuesta = Mensajes.PreguntaAdvertencia("¿Estás seguro de que quieres eliminar el cliente seleccionado?");
                if (respuesta == DialogResult.OK)
                {
                    try
                    {
                        DataGridViewRow renglon = dataGridViewClientes.SelectedRows[0];
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

        private void dataGridViewClientes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn i in dataGridViewClientes.Columns)
            {
                i.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            dataGridViewClientes.AutoResizeColumns();
        }

        private void anteriorBtn_Click(object sender, EventArgs e)
        {
            siguienteBtn.Enabled = true; //Al presionar sobre anterior, se habilita siguiente
            if (clienteIndividual.actual_page > 1)
            {
                dataGridViewClientes.DataSource = clienteIndividual.getPreviousPage();
            }
            if (clienteIndividual.actual_page == 1)
            {
                anteriorBtn.Enabled = false; //Deshabilita anterior porque está en la primer página
            }
            paginaxdey.Text = clienteIndividual.actual_page + "  de  " + clienteIndividual.pages;
        }

        private void siguienteBtn_Click(object sender, EventArgs e)
        {
            anteriorBtn.Enabled = true; //Al presionar sobre siguiente, se habilita anterior
            if (clienteIndividual.actual_page < clienteIndividual.pages)
            {
                dataGridViewClientes.DataSource = clienteIndividual.getNextPage();
            }
            if (clienteIndividual.actual_page == clienteIndividual.pages)
            {
                siguienteBtn.Enabled = false; //Deshabilita siguiente porque está en la última página
            }
            paginaxdey.Text = clienteIndividual.actual_page + "  de  " + clienteIndividual.pages;
        }
    }
}
