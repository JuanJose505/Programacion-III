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
                        return EstadoOrden.Entregado
                    }
            }
            return EstadoOrden;
        }
    }
}
