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

namespace ERP_ventas.Formularios.Ofertas
{
    public partial class OfertasForm : Form
    {
        OfertasDAO ofertasDAO;
        public OfertasForm()
        {
            InitializeComponent();
        }

        private void Ofertas_Load(object sender, EventArgs e)
        {
            //actualizarTabla(); //obsoleto
            try
            {
                dataOfertas.DataSource = ofertasDAO.getNextPage();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }
    }
}
