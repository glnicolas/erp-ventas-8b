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

namespace ERP_ventas.Formularios.Ofertas
{
    public partial class OfertasAgregar : Form
    {
        public OfertasAgregar()
        {
            InitializeComponent();
            modificarBtn.Visible = false;
            btnRegistrar.Visible = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            validarOferta();
        }

        private void validarOferta()
        {
            String errores = "";

            String nombre = txtNombre.Text;
            String descripcion = txtDescripcion.Text;
            double descuento = (double)(numUDDescuento.Value / 100);
            int cantMinProd = (int)numUDCantMinProd.Value;
            String fInicio = dateFechaInicio.Value.Date.Year.ToString()+ "-" + dateFechaInicio.Value.Date.Month.ToString() + "-" + dateFechaInicio.Value.Date.Day.ToString();
            String fFin = dateFechaFin.Value.Date.Year.ToString() + "-" + dateFechaFin.Value.Date.Month.ToString() + "-" + dateFechaFin.Value.Date.Day.ToString();
            
            //Nombre de oferna no null
            if (nombre.Equals(""))
            {
                errores += "Error(es)\n -Agrega un nombre de oferta.\n";
            }

            //nombre de descripción no null
            if (descripcion.Equals(""))
            {
                errores += " -Agrega una descripión de oferta.\n";
            }
      
            if (!(errores.Length>0))
            {
                Oferta oferta = new Oferta(0,nombre,descripcion,descuento,fInicio,fFin,cantMinProd,"A");
                var resultado = new OfertasDAO().Registrar(oferta);
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
                Mensajes.Info(errores);
            }

    
        }

        private void dateFechaFin_ValueChanged(object sender, EventArgs e)
        {
            if (dateFechaInicio.Value.Date>dateFechaFin.Value.Date)
            {
                dateFechaFin.Value = dateFechaInicio.Value;
                MessageBox.Show("No se puede asignar una fecha menor a la inicial", "Error fechas");
            }
        }

        private void dateFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            if (dateFechaInicio.Value.Date > dateFechaFin.Value.Date)
            {
                dateFechaFin.Value = dateFechaInicio.Value;
            }
        }
    }
}
