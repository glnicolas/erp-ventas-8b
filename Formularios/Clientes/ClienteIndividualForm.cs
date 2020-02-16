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
        public ClienteIndividualForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ///*Verificación de ingresar datos*/
           // string nombre, aPaterno, aMaterno, sexo;
            //    mensajeError;

            //nombre = txtNombre.Text;
            //aPaterno = txtAPaterno.Text;
            //aMaterno = txtAMaterno.Text;
            //mensajeError = "Errores: \n";
            ///*
            // * Se utilizan expresiones regulares para que todos los campos sean solo letras.

            // En el caso del nombre existe la posibilidad de tener 2 nombres por lo que se permite el espacio
            // */
            //bool soloLetras = Regex.IsMatch(nombre, @"^[a-zA-Z][a-z A-Z]+$");
            //soloLetras = soloLetras && Regex.IsMatch(aPaterno, @"^[a-zA-Z]+$");
            //soloLetras = soloLetras && Regex.IsMatch(aMaterno, @"^[a-zA-Z]+$");

            //if (soloLetras)
            //{
            //    MessageBox.Show("Todo bien", "titulo");
            //}
            //else
            //{
            //    mensajeError = "-Solo se permiten el uso de letras \n";
            //    if (Regex.IsMatch(nombre, @"^[a-z A-Z][a-zA-Z]+$"))
            //    { //¿Comienza con espacio?
            //        mensajeError += "-No se puede comenzar con espacio \n";
            //    }
            //}

            ////Verificación de campo sexo
            //if (rdtMasculino.Checked)
            //{
            //    sexo = "M";
            //}
            //else if (rdtFemenino.Checked)
            //{
            //    sexo = "F";
            //}
            //else
            //{
            //    mensajeError += "Campo sexo no seleccionado \n";
            //}

            ////Mostrar errores
            //MessageBox.Show(mensajeError, "Error al registrar");
            if (validarCampos())
            {
                char sexo;
                if (rdtMasculino.Checked)
                    sexo = 'M';
                else
                    sexo = 'F';

                Mensajes.Info("nombre: " + txtNombre.Text + " \napellidos: " + txtAPaterno.Text + " " + txtAMaterno.Text + "\nsexo: " + sexo);
            }

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.soloLetras(e);
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

        private void ClienteIndividual_Load(object sender, EventArgs e)
        {

        }
    }
}
