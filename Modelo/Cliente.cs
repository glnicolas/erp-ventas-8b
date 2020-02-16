using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_ventas.Datos
{
    class Cliente
    {
        public int ID { get; set; } 
        public string Direccion { get; set; } 
        public string CP { get; set; } 
        public string RFC { get; set; } 
        public string Telefono { get; set; } 
        public string Email { get; set; } 
        public char Tipo { get; set; } // Usar I para clienteIndividual y T para clienteTienda
        public object InfoCliente { get; set; } //Almacena los datos de ClienteIndividual o ClienteTienda
        public char Estatus { get; set; } 
        public int IDCiudad { get; set; } //Reemplazar con clase Ciudad

        public Cliente(int id, string direccion, string cp, string rfc, string telefono, string email, char tipo, char estatus, int idciudad)
        {
            ID = id;
            Direccion = direccion;
            CP = cp;
            RFC = rfc;
            Telefono = telefono;
            Email = email;
            Tipo = tipo;
            Estatus = estatus;
            IDCiudad = idciudad;
        }


    }
}
