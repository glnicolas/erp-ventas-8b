using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_ventas.Modelo
{
    public class DetalleProducto
    {
        private int ID;
        public string Color { get; set; }
        public double Talla { get; set; }
        public int Existencias { get; set; }

        public DetalleProducto(int id, string color, double talla, int existencias)
        {
            ID = id;
            Color = color;
            Talla = talla;
            Existencias = existencias;
        }
    }
}
