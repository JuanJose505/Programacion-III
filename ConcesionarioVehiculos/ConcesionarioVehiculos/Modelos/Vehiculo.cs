using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using ConcesionarioVehiculos.Enums;
using ConcesionarioVehiculos.Interfaces;

namespace ConcesionarioVehiculos.Modelos
{
    public abstract class Vehiculo
    {
        public string Id { get; set;  }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Year { get; set; }
        public decimal PrecioBase { get; set; }
        public TipoCombustible Combustible { get; set; }
        public EstadoVehiculo Estado { get; set; }

        protected Vehiculo(string id, string marca, string modelo, int year, decimal preciobase, TipoCombustible combustible, EstadoVehiculo estado)
        {
            this.Id = id;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Year = year;
            this.PrecioBase = preciobase;
            this.Combustible = combustible;
            this.Estado = estado;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine("********FACTURA DE VENTA********");
            Console.WriteLine($"Id = {Id}");
            Console.WriteLine($"Marca = {Marca}");
            Console.WriteLine($"Modelo = {Modelo}");
            Console.WriteLine($"Year = {Year}");
            Console.WriteLine($"Precio Base = {PrecioBase}");
            Console.WriteLine($"Combustible = {Combustible}");
            Console.WriteLine($"Estado = {Estado}");    
        }
        
    }
}
