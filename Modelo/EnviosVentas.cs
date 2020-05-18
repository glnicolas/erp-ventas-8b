using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_ventas.Modelo
{
    class EnviosVentas
    {
        public int idEnvio { set; get; }
        public int idVenta { set; get; }
        public DateTime fechaEntregaPlaneada { set; get; }
        public DateTime fechaEntregaReal { set; get; }

        public EnviosVentas(int idEnvio, int idVenta, DateTime fechaEntregaPlaneada, DateTime fechaEntregaReal) 
        {
            this.idEnvio = idEnvio;
            this.idVenta = idVenta;
            this.fechaEntregaPlaneada = fechaEntregaPlaneada;
            this.fechaEntregaReal = fechaEntregaReal;
        }
    }
}
