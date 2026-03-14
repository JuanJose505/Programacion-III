using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Reto1.Modelos
{
    public class Amigo
    {

        public static void CalcularDiasCumple()
        {
            Console.WriteLine("Ingrese el nombre del amigo 1");
            string amigo1 = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del amigo 1");
            string amigo2 = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del amigo 1");
            string amigo3 = Console.ReadLine();

            Console.WriteLine("Ingrese la fecha de cumple de amigo 1");
            string fechacumpleamigo1 = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de cumple de amigo 1");
            string fechacumpleamigo2 = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de cumple de amigo 1");
            string fechacumpleamigo3 = Console.ReadLine();

   

            DateTime fecha1 = DateTime.Parse(fechacumpleamigo1);
            DateTime fecha2 = DateTime.Parse(fechacumpleamigo2);
            DateTime fecha3 = DateTime.Parse(fechacumpleamigo3);

            TimeSpan fecha1final = DateTime.Now - fecha1;
            TimeSpan fecha2final = DateTime.Now - fecha2;
            TimeSpan fecha3final = DateTime.Now - fecha3;

            string data1 = $"{amigo1} cumple el {fecha1}; faltan {fecha1final} para su cumpleaños";

            string data2 = $"{amigo2} cumple el {fecha2}; faltan {fecha2final} para su cumpleaños";

            string data3 = $"{amigo3} cumple el {fecha3}; faltan {fecha3final} para su cumpleaños";

            string ruta = "cumpleaños.txt";

            File.AppendAllText(ruta, data1);
            File.AppendAllText(ruta, data2);
            File.AppendAllText(ruta, data3);

        }

    }
}
