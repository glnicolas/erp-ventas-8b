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

namespace ERP_ventas.Formularios.Clientes
{
    public partial class ClientesIndividualRegistro : Form
    {
        private ClienteIndividualDAO individualDAO;
        public ClientesIndividualRegistro()
        {
            InitializeComponent();
            individualDAO = new ClienteIndividualDAO();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                char sexo;
                if (rdtMasculino.Checked)
                    sexo = 'M';
                else
                    sexo = 'F';

                ClienteIndividual cte = new ClienteIndividual(0, txtNombre.Text, txtAPaterno.Text, txtAMaterno.Text, sexo, 'A');
                try
                {
                    if (individualDAO.ValidarRegistro(cte))
                    {
                        if (individualDAO.Registrar(cte))
                            Mensajes.Info("Registro exitoso");
                        else
                            Mensajes.Error("Error al registrar el cliente");
                    }
                    else
                        Mensajes.Error("El cliente ya existe");


                }
                catch (Exception ex)
                {
                    Mensajes.Error(ex.Message);
                }
            }
        }

        private bool validarCampos()
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                if (!string.IsNullOrWhiteSpace(txtAPaterno.Text))
                {
                    if (!string.IsNullOrWhiteSpace(txtAMaterno.Text))
                    {
                        return true;
                    }
                    else
                    {
                        Mensajes.Info("Ingresa el apellido materno");
                        return false;
                    }
                }
                else
                {
                    Mensajes.Info("Ingresa el apellido paterno");
                    return false;
                }

            }
            else
            {
                Mensajes.Info("Ingresa el nombre(s)");
                return false;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.soloLetras(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
