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
    public partial class Devolucion : Form
    {
        public int cantidadDev { get; set; }
        public string motivo { get; set; }
        public Devolucion(int cantidad)
        {
            InitializeComponent();
            Cant.Maximum =cantidad;
            Cant.Minimum = 1;
        }

        private void Devolucion_Load(object sender, EventArgs e)
        {
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {

            cantidadDev = (int)Cant.Value;
            motivo = txt.Text;
            this.Close();
        }
    }
}
