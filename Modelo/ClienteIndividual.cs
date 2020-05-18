using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_ventas.Modelo
{
    class ClienteIndividual
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apaterno { get; set; }
        public string Amaterno { get; set; }
        public string Sexo { get; set; }
        public char Sexo_char
        {
            get
            {
                if (Sexo.Equals("Masculino"))
                    return 'M';
                else
                    return 'F';
            }
        }

        public ClienteIndividual(int id,string nombre, string apaterno, string amaterno, char sexo)
        {
            ID = id;
            Nombre = nombre;
            Apaterno = apaterno;
            Amaterno = amaterno;
            if (sexo == 'M')
                Sexo = "Masculino";
            else
                Sexo = "Femenino";
        }
        public ClienteIndividual(string nombre, string apaterno, string amaterno, char sexo)
        {
            Nombre = nombre;
            Apaterno = apaterno;
            Amaterno = amaterno;
            if (sexo == 'M')
                Sexo = "Masculino";
            else
                Sexo = "Femenino";
        }
        override
        public string ToString()
        {
            return string.Format("{0} {1} {2}", Nombre, Apaterno,Amaterno);
        }
    }
}
