using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_ventas.Datos
{
    class ClienteIndividual
    {
        public char Sexo_char {
            get
            {
                if (Sexo.Equals("Masculino"))
                    return 'M';
                else
                    return 'F';
            }
        }
        public string Nombre {get; set;}
        public string Apaterno { get; set; }
        public string Amaterno { get; set; }
        public string Sexo { get; set; }

        public ClienteIndividual (string nombre, string apaterno, string amaterno, char sexo)
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
            return "nombre: " + Nombre + "\nApellido Paterno: " + Apaterno + "\nApellido Materno: " + Amaterno + "\nSexo: " + Sexo + "\nSexo_char: " + Sexo_char;
        }
    }
}
