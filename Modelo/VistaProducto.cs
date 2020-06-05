using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_ventas.Modelo
{
    public class VistaProducto
    {
        public int ID { get; set; }
        internal int IDDetalle { get; set; }
        public string Nombre { get; set; }
        public double Talla { get; set; }
        public string Color { get; set; }
        public int Cantidad { get; set; }
        public double PrecioReal { get; set; }
        public double PrecioUnitario { get; set; }
        public double Subtotal { get { return PrecioUnitario * Cantidad; } }
        public string Oferta
        {
            get
            {
                return _producto.Oferta != null ? _producto.Oferta.OfertaString : "No aplica";
            }
        }
        private Producto _producto;

        internal VistaProducto(Producto producto)
        {
            _producto = producto;
            ID = producto.ID;
            Nombre = producto.NombreProducto;
            Talla = producto.detalleSeleccionado.Talla;
            Color = producto.detalleSeleccionado.Color;
            PrecioUnitario = producto.Precio_venta;
            Cantidad = producto.Cantidad;
            IDDetalle = producto.detalleSeleccionado.ID;
            PrecioReal = producto.Precio_real;
        }

        public Producto GetProducto()
        {
            return _producto;
        }

    }
}
