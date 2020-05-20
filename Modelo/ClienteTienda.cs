using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_ventas.Modelo
{
    class ClienteTienda
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Contacto { get; set; }
        public decimal Limite { get; set; }

        public ClienteTienda(int id, string nombre, string contacto, decimal limite)
        {
            ID = id;
            Nombre = nombre;
            Contacto = contacto;
            Limite = limite;
        }

        public ClienteTienda(string nombre, string contacto, decimal limite)
        {
            Nombre = nombre;
            Contacto = contacto;
            Limite = limite;
        }

        override
        public string ToString()
        {
            return string.Format("{0}, Contacto: {1}", Nombre, Contacto);
        }
    }
}
