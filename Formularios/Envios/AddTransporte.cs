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
        public AddTransporte()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(PlacasTB.Text))
            {
                if (!String.IsNullOrWhiteSpace(MarcaTB.Text))
                {
                    if (!String.IsNullOrWhiteSpace(ModeloTB.Text))
                    {
                        if (!String.IsNullOrWhiteSpace(AnioTB.Text))
                        {
                            if (CapacidadTB.Value > 0)
                            {
                                Mensajes.Info("Datos llenados correctamente");
                            }
                            else {
                                Mensajes.Info("La capacidad debe ser mayor que 0");
                            }
                        }
                        else {
                            Mensajes.Info("Debe llenar el campo: Año");
                        }
                    }
                    else {
                        Mensajes.Info("Debe llenar el campo: Modelo");
                    }
                }
                else {
                    Mensajes.Info("Debe llenar el campo: Modelo");
                }
            }
            else {
                Mensajes.Info("Debe llenar el campo: Placas");
            }
        }
    }
}
