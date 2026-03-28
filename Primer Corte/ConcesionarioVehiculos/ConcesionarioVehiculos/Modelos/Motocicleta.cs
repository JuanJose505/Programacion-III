using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConcesionarioVehiculos.Enums;
using ConcesionarioVehiculos.Interfaces;
using Microsoft.Win32.SafeHandles;

namespace ConcesionarioVehiculos.Modelos
{
    public class Motocicleta: Vehiculo, IVendible
    {
        int Cilindraje { get; set; }
        bool esDeportiva { get; set; }

        public Motocicleta(string id, string marca, string modelo, int year, decimal preciobase, TipoCombustible combustible, EstadoVehiculo estado, int cilindraje, bool esdeportiva):base (id, marca, modelo, year, preciobase, combustible, estado)
        {
            this.Cilindraje = cilindraje;
            this.esDeportiva = esdeportiva;
        }

        public decimal CalcularPrecioFinal()
        {
            decimal PrecioFinal = PrecioBase;
            if (esDeportiva)
            {
                return PrecioFinal + (Cilindraje * 10);

            }
            return PrecioFinal;
        }

        public void GenerarFacturaVenta()
        {
            MostrarInformacion();

            Console.WriteLine($"Cilindraje: {Cilindraje}");
            
            if (esDeportiva)
            {
                Console.WriteLine("La moto es deportiva");
            }

            Console.WriteLine($"Precio final {CalcularPrecioFinal()}");

            Console.WriteLine($"Comision del vendedor: {CalcularComisionVendedor()}");
        }

        public decimal CalcularComisionVendedor()
        {
            return CalcularPrecioFinal() * 0.03m;
        }

    }
        
}
