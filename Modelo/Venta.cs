using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_ventas.Modelo
{
    class Venta
    {
        public int ID { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente
        {
            get
            {
                if (ClienteObj != null)
                    return ClienteObj.InfoCliente.ToString();
                else
                    return "Público en general";
            }
        }
        public string Empleado
        {
            get
            {
                if (EmpleadoObj != null)
                    return EmpleadoObj.Emp;
                else
                    return "No asignado";
            }
        }
        public decimal TotalPagar { get; set; }
        public decimal CantidadPagada { get; set; }
        public string Estatus
        {
            get
            {
                switch (EstatusChar)
                {
                    case 'A':
                        return "En Captura";
                    case 'P':
                        return "Pagada";
                    case 'C':
                        return "Cancelada";
                    case 'F':
                        return "Finalizada";
                    default:
                        return "No disponible";
                }
            }
        }
        public string Comentarios;
        internal Empleado EmpleadoObj { get; set; }
        internal Cliente ClienteObj { get; set; }
        internal List<Producto> Productos { get; set; }
        internal char EstatusChar;
        public Venta(int id, DateTime fecha, decimal totalPagar, decimal cantpagada, string comentarios, char estatus, Cliente cliente, Empleado empleado)
        {
            ID = id;
            Fecha = fecha;
            TotalPagar = totalPagar;
            CantidadPagada = cantpagada;
            Comentarios = comentarios;
            EstatusChar = estatus;
            ClienteObj = cliente;
            EmpleadoObj = empleado;
        }
        public Venta(int id, DateTime fecha, char estatus)
        {
            ID = id;
            Fecha = fecha;
            EstatusChar = estatus;
            ClienteObj = null;
            EmpleadoObj = null;
        }
        public Venta()
        {
            ID = 0;
            Fecha = DateTime.Now;
            TotalPagar = 0;
            CantidadPagada = 0;
            EstatusChar = 'A';
            EmpleadoObj = null;
            ClienteObj = null;
        }
        override
        public string ToString()
        {
            return string.Format("ID:[{0}] Fecha:[{1}], Cliente:[{2}]", ID, Fecha.ToShortDateString(), ClienteObj.ID);
        }

    }
}
