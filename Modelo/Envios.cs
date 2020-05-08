using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_ventas.Modelo
{
    public class Envios
    {
        public int idenvio { get; set; }
        public DateTime fechaSalida { get; set; }
        public int idUnidadTransporte { get; set; }
        public char estatus { get; set; }


        public string Env
        {
            get { return fechaSalida + " " + estatus; }
        }

        public Envios(int idenvio,DateTime fechaSalida,int idUnidadTransporte,char estatus)
        {
            this.idenvio = idenvio;
            this.fechaSalida = fechaSalida;
            this.idUnidadTransporte = idUnidadTransporte;
            this.estatus = estatus;
        }

    }
}
