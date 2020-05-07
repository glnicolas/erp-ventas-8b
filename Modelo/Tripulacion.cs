using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_ventas.Modelo
{
    public class Tripulacion
    {
        public int idEmpleado { get; set; }
        public int idEnvio { get; set; }
        public string rol {get; set;}

        public Tripulacion(int idEmpleado, int idEnvio, string rol ) 
        {
            this.idEmpleado = idEmpleado;
            this.idEnvio = idEnvio;
            this.rol = rol;
        }
    }

    
}
