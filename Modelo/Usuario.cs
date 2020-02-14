using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_ventas.Modelo
{
    class Usuario
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Contra { get; set; }
        public char Estatus { get; set; }
        public string Tipo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IDEmpleado { get; set; } //Reemplazar con un objeto de tipo Empleado

        public Usuario(int id, string nombre, string contra, char estatus, string tipo, DateTime fecharegistro, int idempleado)
        {
            ID = id;
            Nombre = nombre;
            Contra = contra;
            Estatus = estatus;
            Tipo = tipo;
            FechaRegistro = fecharegistro;
            IDEmpleado = idempleado;
        }
    }
}
