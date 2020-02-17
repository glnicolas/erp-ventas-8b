using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_ventas.Modelo
{
    class ClienteTienda
    {
        public string Nombre { get; set; }
        public string Contacto { get; set; }
        public decimal Limite { get; set; }

        public ClienteTienda(string nombre, string contacto, decimal limite)
        {
            Nombre= nombre;
            Contacto= contacto;
            Limite = limite;
        }
    }
}
