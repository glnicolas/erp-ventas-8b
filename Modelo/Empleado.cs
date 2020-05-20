using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_ventas.Modelo
{
    public class Empleado
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apaterno { get; set; }
        public string Amaterno { get; set; }
        public Bitmap Fotografia { get; set; }
        public string Emp
        {
            get { return Nombre + " " + Apaterno; }
        }
        public Empleado(int id, string nombre, string apaterno, string amaterno, byte[] foto_bytes)
        {
            ID = id;
            Nombre = nombre;
            Apaterno= apaterno;
            Amaterno = amaterno;
            Fotografia = new Bitmap(new System.IO.MemoryStream(foto_bytes));
        }

        public Empleado(int id, string nombre, string apaterno, string amaterno)
        {
            ID = id;
            Nombre = nombre;
            Apaterno = apaterno;
            Amaterno = amaterno;
        }
    }
}
