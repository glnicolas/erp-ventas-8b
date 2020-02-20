using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_ventas.Modelo
{
    public class Ciudad
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public Ciudad(int iD, string nombre)
        {
            ID = iD;
            Nombre = nombre;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
