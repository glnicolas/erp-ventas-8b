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

namespace ERP_ventas.Formularios.Envios
{
    public partial class AddTransporte : Form
    {
        TransporteDAO transporteDAO;
        private Transporte tr;

        public AddTransporte()
        {
            InitializeComponent();
            transporteDAO = new TransporteDAO();
            modificarButton.Visible = false;
            btnNuevo.Visible = true;
        }

        public AddTransporte(Transporte transporte)
        {
            InitializeComponent();
            transporteDAO = new TransporteDAO();
            this.tr = transporte;
            PlacasTB.Text = tr.Placas;
            MarcaTB.Text = tr.Marca;
            ModeloTB.Text = tr.Modelo;
            AnioTB.Text = tr.Anio.ToString();
            CapacidadTB.Text = tr.Capacidad.ToString();
            label8.Text = "Modificar Transporte";
            modificarButton.Visible = true;
            btnNuevo.Visible = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                try
                {
                    Transporte tr = new Transporte(0, PlacasTB.Text, MarcaTB.Text, ModeloTB.Text,
                        int.Parse(AnioTB.Text), int.Parse(CapacidadTB.Value.ToString()), 'A');

                    var resultado = transporteDAO.Registrar(tr);
                    Type resultado_tipo = resultado.GetType();

                    if (resultado_tipo.Equals(typeof(string)))
                    {
                        Mensajes.Error(resultado.ToString());
                    }
                    else
                    {
                        Mensajes.Info("Registro exitoso.");
                        this.Close();
                    }

                }
                catch (Exception ex)
                {
                    Mensajes.Error(ex.Message);
                }
            }
        }

        private bool validarDatos()
        {
            if (PlacasTB.MaskCompleted)
            {
                if (!string.IsNullOrWhiteSpace(MarcaTB.Text))
                {
                    if (!string.IsNullOrWhiteSpace(ModeloTB.Text))
                    {
                        if (AnioTB.MaskCompleted)
                        {
                            return true;
                        }
                        else
                        {
                            Mensajes.Info("Ingresa el Año");
                            return false;
                        }
                    }
                    else
                    {
                        Mensajes.Info("Ingresa el Modelo");
                        return false;
                    }
                }
                else
                {
                    Mensajes.Info("Ingresa la Marca");
                    return false;
                }
            }
            else
            {
                Mensajes.Info("Ingresa las Placas");
                return false;
            }
        }


        private void AddTransporte_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                try
                {
                    Transporte trans = new Transporte(tr.ID, PlacasTB.Text, MarcaTB.Text, ModeloTB.Text,
                        int.Parse(AnioTB.Text), int.Parse(CapacidadTB.Value.ToString()), 'A');

                    var resultado = transporteDAO.Editar(trans);
                    Type resultado_tipo = resultado.GetType();

                    if (resultado_tipo.Equals(typeof(string)))
                    {
                        Mensajes.Error(resultado.ToString());
                    }
                    else
                    {
                        Mensajes.Info("Modificación exitosa.");
                        this.Close();
                    }

                }
                catch (Exception ex)
                {
                    Mensajes.Error(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
