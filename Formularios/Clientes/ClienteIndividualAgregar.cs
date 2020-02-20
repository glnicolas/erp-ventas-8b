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


namespace ERP_ventas.Formularios.Clientes
{
    public partial class ClienteIndividualAgregar : Form
    {
        ClienteDAO clienteDAO;
        Cliente cliente;
        public ClienteIndividualAgregar()
        {

            clienteDAO = new ClienteDAO();
            InitializeComponent();
            generarCiudades();

        }

        public ClienteIndividualAgregar(Cliente cliente)
        {
            clienteDAO = new ClienteDAO();
            InitializeComponent();
            generarCiudades();
            this.cliente = cliente;

        }

        private void generarCiudades()
        {
            //impide que se modifique el comboBox
            comboBoxCiudad.DropDownStyle = ComboBoxStyle.DropDownList;

            string sql_where = "";
            List<string> parametros = new List<string>();
            List<object> valores = new List<object>();

            List<Ciudad> ciudades = clienteDAO.ConsultaCiudades(sql_where, parametros, valores);
            foreach (Ciudad ciudad in ciudades)
            {
                comboBoxCiudad.Items.Add(ciudad);

            }
        }


        private void comboBoxCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {


        }

        private void validarEntradas()
        {
            String mensaje = "";

            String rfc = txtRFC.Text;
            String telefono = txtTelefono.Text;
            String codigoPostal = txtCodigoPostal.Text;

            bool soloLetras = Regex.IsMatch(rfc, @"^[a-zA-Z][a-z A-Z]+$");
            //RFC Valido
            /*
             * Morales: Se compone de 3 letras seguidas por 6 dígitos y 3 caracteres alfanumericos =12
             * Físicas: consta de 4 letras seguida por 6 dígitos y 3 caracteres alfanuméricos =13 */
            if (Regex.IsMatch(rfc, @"^[a-zA-Z][a-zA-Z][a-zA-Z][0-9][0-9][0-9][0-9][0-9][0-9][a-zA-Z0-9][a-zA-Z0-9][a-zA-Z0-9]$") |
                Regex.IsMatch(rfc, @"^[a-zA-Z][a-zA-Z][a-zA-Z][a-zA-Z][0-9][0-9][0-9][0-9][0-9][0-9][a-zA-Z0-9][a-zA-Z0-9][a-zA-Z0-9]$"))
            {
                //Es valido
            }
            else
            {
                mensaje += "\n RFC Invalido";
            }


            //Telefono
            /* Validar que este completo
             */
            if (Regex.IsMatch(telefono, @"^[0-9][0-9][0-9]-[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]$"))
            {
                //Es valido
            }
            else
            {
                mensaje += "\n Telefono Invalido";
            }


            //Código postal
            /* Validar que este completo
             */
            if (Regex.IsMatch(codigoPostal, @"^[0-9][0-9][0-9][0-9][0-9]$"))
            {
                //Es valido
            }
            else
            {
                mensaje += "\n Codigo postal Invalido, completar.";
            }


            /*Verificar si existe algun mensaje de error*/
            if (mensaje.Equals(""))
            {
                try
                {
                    char sexo;
                    if (rbSexo.Checked)
                        sexo = 'M';
                    else
                        sexo = 'F';

                    Ciudad cdd = (Ciudad)comboBoxCiudad.SelectedItem;
                    ClienteIndividual ctetinds = new ClienteIndividual(txtNombre.Text, txtAPaterno.Text, txtAMaterno.Text, sexo);
                    Cliente cte = new Cliente(0, txtDireccion.Text, txtCodigoPostal.Text, txtRFC.Text, txtTelefono.Text, txtEmail.Text, 'I', 'A', cdd.ID);
                    cte.InfoCliente = ctetinds;
                    if (cliente != null)
                    {
                        cte.ID = cliente.ID;
                        var resultado = new ClienteDAO().Editar(cte);
                        Type resultado_tipo = resultado.GetType();

                        if (resultado_tipo.Equals(typeof(string)))
                        {
                            Mensajes.Error(resultado.ToString());
                        }
                        else
                        {
                            Mensajes.Info("Actualización exitosa.");
                            Close();
                        }
                    }
                    else
                    {
                        var resultado = new ClienteDAO().Registrar(cte);
                        Type resultado_tipo = resultado.GetType();
                        if (resultado_tipo.Equals(typeof(string)))
                        {
                            Mensajes.Error(resultado.ToString());
                        }
                        else
                        {
                            Mensajes.Info("Registro exitoso.");
                            Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Mensajes.Error(ex.Message);
                }
            }
            if (mensaje.Length > 0)
                MessageBox.Show(mensaje);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            validarEntradas();
        }

        private void ClienteIndividualAgregar_Load(object sender, EventArgs e)
        {
            if (this.cliente != null)
            {
                txtNombre.Text = ((ClienteIndividual)cliente.InfoCliente).Nombre;
                txtAPaterno.Text = ((ClienteIndividual)cliente.InfoCliente).Apaterno;
                txtNombre.Text = ((ClienteIndividual)cliente.InfoCliente).Nombre;
                txtDireccion.Text = cliente.Direccion;
                txtCodigoPostal.Text = cliente.CP;
                txtEmail.Text = cliente.Email;
                txtTelefono.Text = cliente.Telefono;
                txtRFC.Text = cliente.RFC;

                var ciudades = comboBoxCiudad.Items;
                foreach(Ciudad ciudad in ciudades)
                {
                    if (ciudad.ID == cliente.ID)
                    {
                        comboBoxCiudad.SelectedItem = ciudad;
                    }
                }
            }
        }
    }
}
