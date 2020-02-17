using ERP_ventas.Datos;
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
        public ClienteIndividualForm()
        {
            InitializeComponent();
            clienteDAO = new ClienteDAO();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }


        private void ClienteIndividual_Load(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void actualizarTabla()
        {
            string sql_where = " where estatus=@estatus and tipo=@tipo";
            List<string> parametros = new List<string>(); 
            List<object> valores = new List<object>();

            parametros.Add("@estatus");
            valores.Add('A');

            parametros.Add("@tipo");
            valores.Add('I');

            llenarTabla(clienteDAO.ConsultaGeneral(sql_where, parametros, valores));
        }

        private void llenarTabla(List<Cliente> clientes)
        {
            foreach (Cliente cliente in clientes)
            {
                DataGridViewRow renglon = new DataGridViewRow();
                renglon.CreateCells(dataGridViewClientes);

                renglon.Cells[0].Value = cliente.ID;
                renglon.Cells[1].Value = ((ClienteIndividual)cliente.InfoCliente).Nombre;
                renglon.Cells[2].Value = ((ClienteIndividual)cliente.InfoCliente).Apaterno;
                renglon.Cells[3].Value = ((ClienteIndividual)cliente.InfoCliente).Amaterno;
                renglon.Cells[4].Value = ((ClienteIndividual)cliente.InfoCliente).Sexo;
                renglon.Cells[5].Value = cliente.Direccion;
                renglon.Cells[6].Value = cliente.CP;
                renglon.Cells[7].Value = cliente.RFC;
                renglon.Cells[8].Value = cliente.Telefono;
                renglon.Cells[9].Value = cliente.Email;
                renglon.Cells[10].Value = cliente.IDCiudad;

                dataGridViewClientes.Rows.Add(renglon);
            }
        }

        private void dataGridViewClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
