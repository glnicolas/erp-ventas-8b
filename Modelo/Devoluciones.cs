using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_ventas.Modelo
{
    class Devoluciones
    {
        int idDevolucion { set; get; }
        DateTime fecha { set; get; }
        int idProductoDetalle { set; get; }
        int cantidad { set; get; }
        float precioUnitario { set; get; }
        float total { set; get; }
        string motivo { set; get; }
        int idVenta { set; get; }

        public Devoluciones(int idDev, DateTime fecha, int idProDet, int Cant, float PrecioU, float total, string motivo, int idVenta)
        {
            this.idDevolucion = idDev;
            this.fecha = fecha;
            this.idProductoDetalle = idProDet;
            this.cantidad = Cant;
            this.precioUnitario = PrecioU;
            this.total = total;
            this.motivo = motivo;
            this.idVenta = idVenta;
        }
    }
}
