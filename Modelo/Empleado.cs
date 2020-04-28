using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_ventas.Modelo
{
    class Empleado
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apaterno { get; set; }
        public string Amaterno { get; set; }
        public Bitmap Fotografia { get; set; }
        public int idDepartamento { get; set; }
        public int idPuesto { get; set; }

        /* char Sexo { get; set; }
        DateTime FechaContratacion { get; set; }
        DateTime FechaNacimiento { get; set; }
        decimal Salario { get; set; }
        string Nss { get; set; }
        string EstadoCivil { get; set; }
        int DiasVacaciones { get; set; }
        int DiasPermiso { get; set; } 
        string Direccion { get; set; }
        string Colonia { get; set; }
        string CodigoPostal { get; set; }
        string Escolaridad { get; set; }
        float PorcentajeComision { get; set; } 
        int idCiudad { get; set; }
        */

        public Empleado(int id, string nombre, string apaterno, string amaterno, byte[] foto_bytes)
        {
            ID = id;
            Nombre = nombre;
            Apaterno= apaterno;
            Amaterno = amaterno;
            Fotografia = new Bitmap(new System.IO.MemoryStream(foto_bytes));
        }
    }
}
