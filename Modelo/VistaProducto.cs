using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_ventas.Modelo
{
    class VistaProducto
    {
        public int ID {get;set;}
        public string Nombre { get; set; }
        public double Talla { get; set; }
        public string Color { get; set; }
        public int Cantidad { get; set; }

        public double PrecioUnitario { get; set; }

        public Producto _producto;

        internal VistaProducto(Producto producto)
        {
            _producto = producto;
            ID = producto.ID;
            Nombre = producto.NombreProducto;
            Talla = producto.detalleSeleccionado.Talla;
            Color = producto.detalleSeleccionado.Color;
            PrecioUnitario = producto.Precio_venta;
            Cantidad = producto.Cantidad;
        }

        public Producto GetProducto()
        {
            return _producto;
        }

    }
}
