using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using SistemaRestaurante.Enums;
using SistemaRestaurante.Modelos;

namespace SistemaRestaurante
{
    public class Program
    {
        static void Main(string[] args)
        {
            Entrada entrada1 = new Entrada("123", "Pan", "El pan es tal tal tal", 5000, TipoComida.Vegetariana, NivelDificultad.Intermedio, EstadoOrden.Preparado, false, 5);
            entrada1.MostrarInformacionNutricional();
            entrada1.CalcularTiempoPreparacion();
            

            PlatoPrincipal plato1 = new PlatoPrincipal("0404", "Pastas", "Las pastas son ricas jeje", 50000, TipoComida.Carnivora, NivelDificultad.Avanzado, EstadoOrden.Pediente, "Albondigas", true);
            plato1.MostrarInformacionNutricional();
            plato1.CalcularTiempoPreparacion();
            
            
        }
        


        private TipoComida CalcularTipoComida()
        {
            Console.WriteLine("Que tipo de comida escogera?");
            Console.WriteLine("1-Vegetariana");
            Console.WriteLine("2-Vegana");
            Console.WriteLine("3-Carnivora");
            Console.WriteLine("4-Mariscos");
            Console.WriteLine("5-Mixta");

            int menu = int.Parse(Console.ReadLine());
            switch (menu)
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
                        Console.WriteLine("El valor ingresado no equivale a un tipo de comida");
                        return TipoComida.Desconocida;
                    }
            }
        }

        private NivelDificultad CalcularDificultad()
        {
            Console.WriteLine("Que dificultad tiene el plato?");
            Console.WriteLine("1-Facil");
            Console.WriteLine("2-Intermedio");
            Console.WriteLine("3-Avanzado");
            

            int menu = int.Parse(Console.ReadLine());
            switch (menu)
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
                        Console.WriteLine("El valor ingresado no equivale a una dificultad");
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

            int menu = int.Parse(Console.ReadLine());
            switch (menu)
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
                        return EstadoOrden.Entregado;
                    }
            }
            
        }
    }
}
