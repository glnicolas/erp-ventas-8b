using System;
using System.Windows.Forms;
using ERP_ventas.Modelo;
using ERP_ventas.Datos;
using System.Collections.Generic;

namespace ERP_ventas.Formularios.Clientes
{
    public partial class BuscarClientesForm : Form
    {
        public char tipoCliente;
        public object cliente = null;

        public BuscarClientesForm(object cliente,char tipoCliente)
        {
            InitializeComponent();
            comboBoxTipo.SelectedIndex = 0;
        }

        private void limpiarbutton_Click(object sender, EventArgs e)
        {
            if (buscartextBox.Text != "")
            {
                tipoCliente = comboBoxTipo.SelectedItem.ToString()[0];
                try
                {
                    if (tipoCliente == 'I')
                    {
                        dataGridViewClientes.DataSource = new ClienteIndividualDAO().ConsultaGeneral(
                            "  where CONCAT(nombre,' ',apaterno,' ',amaterno) like '%'+@buscar+'%' ",
                            new List<string>() { "@buscar" },
                            new List<object>() { buscartextBox.Text });
                    }
                    else
                    {
                        dataGridViewClientes.DataSource = new ClienteTiendaDAO().ConsultaGeneral(
                            " where CONCAT(nombre,' ',contacto) like '%'+ @buscar+'%'",
                            new List<string>() { "@buscar" },
                            new List<object>() { buscartextBox.Text });
                    }

                    if(dataGridViewClientes.Rows.Count==0)
                    {
                        DialogResult respuesta = Mensajes.PreguntaInfo("No se ha encontrado ningún cliente,\n" +
                            "¿quieres registrar uno nuevo?");
                        if (respuesta == DialogResult.OK)
                        {
                            SubMClientes subMClientes = new SubMClientes(1);
                            subMClientes.Show();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Mensajes.Error(ex.Message);
                }
            }
            else
                Mensajes.Info("Ingresa un nombre");
        }

        private void BuscarClientesForm_Load(object sender, EventArgs e)
        {
            dataGridViewClientes.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewClientes.DataSource = null;
        }

        private void dataGridViewClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridViewClientes.SelectedRows[0];
            if (tipoCliente == 'I')
            {
                cliente = (ClienteIndividual)row.DataBoundItem;

                DialogResult respuesta = Mensajes.PreguntaInfo(
                    string.Format("¿Seleccionar al cliente {0} {1} {2}?",
                    (cliente as ClienteIndividual).Nombre,
                    (cliente as ClienteIndividual).Apaterno, 
                    (cliente as ClienteIndividual).Amaterno));
                if (respuesta == DialogResult.OK)
                    Close();
            }
            else
            {
                cliente = (ClienteTienda)row.DataBoundItem;
                DialogResult respuesta = Mensajes.PreguntaInfo(
                    string.Format("¿Seleccionar al cliente {0}: {1}?",
                    (cliente as ClienteTienda).Nombre, (cliente as ClienteTienda).Contacto));
                if (respuesta == DialogResult.OK)
                    Close();
            }

            Mensajes.Info(cliente.ToString());


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SubMClientes subMClientes = new SubMClientes(1);
            subMClientes.Show();
        }
    }
}
