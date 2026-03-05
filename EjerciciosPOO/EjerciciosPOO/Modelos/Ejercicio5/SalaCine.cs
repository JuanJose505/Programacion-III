using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO.Modelos.Ejercicio5
{
    internal class SalaCine
    {
        string Pelicula { get; set; }
        int Capacidad_Maxima { get; set; }
        int Asientos_Ocupados { get; set; }
        int Precio_Entrada { get; set; }

        public SalaCine(string pelicula, int capacidad_maxima, int asientos_ocupados, int precio_entrada)
        {
            this.Pelicula = pelicula;
            this.Capacidad_Maxima = capacidad_maxima;
            this.Asientos_Ocupados = asientos_ocupados;
            this.Precio_Entrada = precio_entrada;
        }


        public void VerDisponibilidad()
        {
            Console.WriteLine($"Quedan {Capacidad_Maxima - Asientos_Ocupados} asientos disponibles!");
        }

        public void ComprarEntradas(int cantidad_entradas_comprar)
        {
            Asientos_Ocupados += cantidad_entradas_comprar;
            Console.WriteLine("Se han comprado sus entradas con exito");
        }
    }
}
