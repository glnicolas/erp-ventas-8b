using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_ventas.Modelo
{
	


    class ClienteTienda
    {

		public string Nombre { get; set; }
		public string Contacto { get; set; }
		public float LimiteCredito { get; set; }
		public char Estatus { get; set; }
		public string Direccion { get; set; }
		public string CodigoPostal { get; set; }
		public string rfc { get; set; }
		public string telefono { get; set; }
		public string email { get; set; }
		public char tipo { get; set; }
		public string Ciudad { get; set; }
		
		public ClienteTienda(string nombre,string Contacto,float LimiteCredito,char Estatus,string Direccion,string CodigoPostal,string rfc,string telefono,string email,char tipo,string ciudad)
		{
			this.Nombre = nombre;
			this.Contacto = Contacto;
			this.LimiteCredito = LimiteCredito;
			this.Estatus = Estatus;
			this.Direccion = Direccion;
			this.CodigoPostal = CodigoPostal;
			this.rfc = rfc;
			this.telefono = telefono;
			this.email = email;
			this.tipo = tipo;
			this.Ciudad = ciudad;


		}
	}
}
