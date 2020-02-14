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
        public Image Estatus { get; set; }
        public string Tipo { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Empleado(int id, string nombre, char estatus, string tipo, DateTime fecharegistro, int idempleado)
        {
            ID = id;
            Nombre = nombre;
            //Estatus = estatus;
            //Tipo = tipo;
            //FechaRegistro = fecharegistro;
            //IDEmpleado = idempleado;
        }
    }
}
