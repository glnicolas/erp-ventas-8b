using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_ventas.Modelo
{
    class Estado
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        public List<Ciudad> Ciudades = new List<Ciudad>();
    }
}
