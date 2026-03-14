using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalcularDiasCumple();
        }

        public static void CalcularDiasCumple()
        {
            Console.WriteLine("Ingrese el nombre del amigo 1");
            string amigo1 = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del amigo 2");
            string amigo2 = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del amigo 3");
            string amigo3 = Console.ReadLine();

            Console.WriteLine("Ingrese la fecha de cumple de amigo 1");
            string fechacumpleamigo1 = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de cumple de amigo 2");
            string fechacumpleamigo2 = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de cumple de amigo 3");
            string fechacumpleamigo3 = Console.ReadLine();

            fechacumpleamigo1 = fechacumpleamigo1;

            DateTime fecha1 = DateTime.Parse(fechacumpleamigo1);
            DateTime fecha2 = DateTime.Parse(fechacumpleamigo2);
            DateTime fecha3 = DateTime.Parse(fechacumpleamigo3);

            TimeSpan fecha1final = fecha1 - DateTime.Now;
            TimeSpan fecha2final = fecha2 - DateTime.Now;
            TimeSpan fecha3final = fecha3 - DateTime.Now;

            string data1 = $"{amigo1} cumple el {fecha1}; faltan {fecha1final.Days} para su cumpleaños ;";

            string data2 = $"{amigo2} cumple el {fecha2}; faltan {fecha2final.Days} para su cumpleaños ;";

            string data3 = $"{amigo3} cumple el {fecha3}; faltan {fecha3final.Days} para su cumpleaños ;";

            string ruta = "cumpleaños.txt";

            File.AppendAllText(ruta, data1);
            File.AppendAllText(ruta, data2);
            File.AppendAllText(ruta, data3);

        }
    }
}
