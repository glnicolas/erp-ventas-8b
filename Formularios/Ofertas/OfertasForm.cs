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
            ofertasDAO = new OfertasDAO();
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
                Mensajes.Error("ERROR:: "+ex.Message);
            }
        }

        private void dataOfertas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn i in dataOfertas.Columns)
            {
                i.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            dataOfertas.AutoResizeColumns();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            OfertasAgregar ofertasAgregar = new OfertasAgregar();
            ofertasAgregar.ShowDialog();
        }
    }
}
