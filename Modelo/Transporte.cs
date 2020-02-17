using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_ventas.Modelo
{
    public class Transporte
    {
        public int ID { get; set; }
        public string Placas { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public int Capacidad { get; set; }
        public char Estatus { get; set; }

        public Transporte(int id, string placas, string marca, string modelo, int anio, int cap, char estatus) {
            ID = id;
            Placas = placas;
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            Capacidad = cap;
            Estatus = estatus;
        }
    }
}
