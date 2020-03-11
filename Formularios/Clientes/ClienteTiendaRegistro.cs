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
    public partial class ClienteTiendaRegistro : Form
    {
        private Cliente cliente;

        public ClienteTiendaRegistro()
        {
            InitializeComponent();
            modificarBtn.Visible = false;
            btnAgregarCliente.Visible = true;
        }

        public ClienteTiendaRegistro(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            label1.Text = "Modificar cliente";
            modificarBtn.Visible = true;
            btnAgregarCliente.Visible = false;

        }

        private void ClienteTiendaRegistro_Load(object sender, EventArgs e)
        {
            comboBoxCiudad.Items.AddRange((new ClienteDAO().ConsultaCiudades("", new List<string>(), new List<object>())).ToArray());
            if (cliente != null)
            {
                MtxtNombre.Text = ((ClienteTienda)cliente.InfoCliente).Nombre;
                MtxtContacto.Text = ((ClienteTienda)cliente.InfoCliente).Contacto;
                NumCredito.Value = ((ClienteTienda)cliente.InfoCliente).Limite;
                MtxtDireccion.Text = cliente.Direccion;
                MtxtCodigoPostal.Text = cliente.CP;
                MtxtRFC.Text = cliente.RFC;
                MtxtTelefono.Text = cliente.Telefono;
                MtxtEmail.Text = cliente.Email;

                foreach (Ciudad ciudad in comboBoxCiudad.Items)
                {
                    if (ciudad.ID == cliente.IDCiudad)
                        comboBoxCiudad.SelectedItem = ciudad;
                }
            }
        }

        private bool validarDatos()
        {
            if (!string.IsNullOrWhiteSpace(MtxtNombre.Text))
            {
                if (!string.IsNullOrWhiteSpace(MtxtContacto.Text))
                {
                    if (!string.IsNullOrWhiteSpace(MtxtDireccion.Text))
                    {
                        if (MtxtCodigoPostal.MaskCompleted)
                        {
                            if (MtxtRFC.MaskCompleted)
                            {
                                if (MtxtTelefono.MaskCompleted)
                                {
                                    if (!string.IsNullOrWhiteSpace(MtxtEmail.Text))
                                    {
                                        if (comboBoxCiudad.SelectedIndex >= 0)
                                        {
                                            return true;
                                        }
                                        else
                                        {
                                            Mensajes.Info("Selecciona una ciudad");
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        Mensajes.Info("Ingresa el correo");
                                        return false;
                                    }
                                }
                                else
                                {
                                    Mensajes.Info("Ingresa el telefono");
                                    return false;
                                }
                            }
                            else
                            {
                                Mensajes.Info("Ingresa el RFC");
                                return false;
                            }
                        }
                        else
                        {
                            Mensajes.Info("Ingresa el codigo postal");
                            return false;
                        }
                    }
                    else
                    {
                        Mensajes.Info("Ingresa la direccion");
                        return false;
                    }
                }
                else
                {
                    Mensajes.Info("Ingresa el nombre del contacto");
                    return false;
                }
            }
            else
            {
                Mensajes.Info("Ingresa el nombre");
                return false;
            }

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                try
                {
                    ClienteTienda ctetda = new ClienteTienda(MtxtNombre.Text, MtxtContacto.Text, NumCredito.Value);
                    Cliente cte = new Cliente(0, MtxtDireccion.Text, MtxtCodigoPostal.Text, MtxtRFC.Text, MtxtTelefono.Text, MtxtEmail.Text, 'T', 'A', ((Ciudad)comboBoxCiudad.SelectedItem).ID);
                    cte.InfoCliente = ctetda;

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
                catch (Exception ex)
                {
                    Mensajes.Error(ex.Message);
                }
            }
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                try
                {
                    ClienteTienda ctetda = new ClienteTienda(MtxtNombre.Text, MtxtContacto.Text, NumCredito.Value);
                    Cliente cte = new Cliente(cliente.ID, MtxtDireccion.Text, MtxtCodigoPostal.Text, MtxtRFC.Text, MtxtTelefono.Text, MtxtEmail.Text, 'T', 'A', ((Ciudad)comboBoxCiudad.SelectedItem).ID);
                    cte.InfoCliente = ctetda;

                    var resultado = new ClienteDAO().Editar(cte);
                    Type resultado_tipo = resultado.GetType();

                    if (resultado_tipo.Equals(typeof(string)))
                    {
                        Mensajes.Error(resultado.ToString());
                    }
                    else
                    {
                        Mensajes.Info("Modificación exitosa.");
                        Close();
                    }

                }
                catch (Exception ex)
                {
                    Mensajes.Error(ex.Message);
                }
            }
        }

        private void MtxtRFC_Leave(object sender, EventArgs e)
        {
            //if (!Regex.IsMatch(MtxtRFC.Text, @"^[a-zA-Z][a-zA-Z][a-zA-Z][0-9][0-9][0-9][0-9][0-9][0-9][a-zA-Z0-9][a-zA-Z0-9][a-zA-Z0-9]$"))
            //{
            //    Mensajes.Info("El RFC no es válido");
            //    MtxtRFC.Focus();
            //}
        }

        private void MtxtContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.soloLetras(e);
        }

        private void MtxtEmail_Leave(object sender, EventArgs e)
        {
            if (!Utilidades.IsValidEmail(MtxtEmail.Text))
            {
                Mensajes.Info("El correo no es válido");
                MtxtEmail.Focus();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
