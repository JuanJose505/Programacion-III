using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using SistemaRestaurante.Enums;

namespace SistemaRestaurante
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }

        private TipoComida CalcularElTipoComida()
        {
            Console.WriteLine("Que tipo de comida es:");
            Console.WriteLine("1-Vegetariana");
            Console.WriteLine("2-Vegana");
            Console.WriteLine("3-Carnivora");
            Console.WriteLine("4-Mariscos");
            Console.WriteLine("5-Mixta");


            int estado_orden_menu = int.Parse(Console.ReadLine());
            switch (estado_orden_menu)
            {
                case 1:
                    {
                        Console.WriteLine(TipoComida.Vegetariana);
                        return TipoComida.Vegetariana;
                    }
                case 2:
                    {
                        Console.WriteLine(TipoComida.Vegana);
                        return TipoComida.Vegana;
                    }
                case 3:
                    {
                        Console.WriteLine(TipoComida.Carnivora);
                        return TipoComida.Carnivora;
                    }
                case 4:
                    {
                        Console.WriteLine(TipoComida.Mariscos);
                        return TipoComida.Mariscos;
                    }
                case 5:
                    {
                        Console.WriteLine(TipoComida.Mixta);
                        return TipoComida.Mixta;
                    }
                default:
                    {
                        Console.WriteLine(TipoComida.Desconocida);
                        return TipoComida.Desconocida;
                    }
            }
        }
        private NivelDificultad CalcularNivelDificultad()
        {
            Console.WriteLine("En que dificultad se encuentra la orden?");
            Console.WriteLine("1-Facil");
            Console.WriteLine("2-Intermedio");
            Console.WriteLine("3-Avanzado");

            int estado_orden_menu = int.Parse(Console.ReadLine());
            switch (estado_orden_menu)
            {
                case 1:
                    {
                        Console.WriteLine(NivelDificultad.Facil);
                        return NivelDificultad.Facil;
                    }
                case 2:
                    {
                        Console.WriteLine(NivelDificultad.Intermedio);
                        return NivelDificultad.Intermedio;
                    }
                case 3:
                    {
                        Console.WriteLine(NivelDificultad.Avanzado);
                        return NivelDificultad.Avanzado;
                    }

                default:
                    {
                        Console.WriteLine(NivelDificultad.Desconocido);
                        return NivelDificultad.Desconocido;
                    }
            }
        }

        private EstadoOrden CalcularEstadoOrden()
        {
            Console.WriteLine("En que estado se encuentra la orden?");
            Console.WriteLine("1-Pendiente");
            Console.WriteLine("2-Preparado");
            Console.WriteLine("3-Listo");
            Console.WriteLine("4-Entregado");
            

            int estado_orden_menu = int.Parse(Console.ReadLine());
            switch (estado_orden_menu)
            {
                case 1:
                    {
                        Console.WriteLine(EstadoOrden.Pediente);
                        return EstadoOrden.Pediente;
                    }
                case 2:
                    {
                        Console.WriteLine(EstadoOrden.Preparado);
                        return EstadoOrden.Preparado;
                    }
                case 3:
                    {
                        Console.WriteLine(EstadoOrden.Listo);
                        return EstadoOrden.Listo;
                    }
                case 4:
                    {
                        Console.WriteLine(EstadoOrden.Entregado);
                        return EstadoOrden.Entregado;
                    }
                default:
                    {
                        Console.WriteLine(EstadoOrden.Desconocido);
                        return EstadoOrden.Desconocido;
                    }
            }
            
        }
    }
}
