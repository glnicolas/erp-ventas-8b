using ERP_ventas.Modelo;
using ERP_ventas.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_ventas.Formularios.Ventas
{
    public partial class PagosForm : Form
    {
        private Venta venta;
        public PagosForm(Modelo.Venta vta)
        {
            InitializeComponent();
            venta = vta;
        }

        private void PagosForm_Load(object sender, EventArgs e)
        {
            labelVenta.Text = "No. " + venta.ID;
            textBox1.Text = venta.TotalPagar.ToString("C2");
            numericUpDown2.Maximum = venta.TotalPagar;
            numericUpDown2.Minimum = venta.CantidadPagada;
            numericUpDown2.Value = venta.CantidadPagada;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (numericUpDown2.Value != 0)
            {
                try
                {
                    if (numericUpDown2.Value == venta.TotalPagar)
                        venta.EstatusChar = 'P';
                    else
                        venta.EstatusChar = 'E';
                    venta.CantidadPagada = numericUpDown2.Value;
                    VentaDAO dAO = new VentaDAO();
                    if (dAO.Actualizar(venta))
                    {
                        Mensajes.Info("Cobro realizado exitosamente");
                        Close();
                    }
                    else
                        Mensajes.Info("Ha ocurrido un error, intenta más tarde");
                }
                catch (Exception ex)
                {
                    Mensajes.Error(ex.Message);
                }
            }else
                Mensajes.Info("Ingresa una cantidad a pagar");
        }
    }
}
