using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiarioPersonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre");
            string nombreusuario = Console.ReadLine();

            Console.WriteLine("Escribe un pensamiento/actividad del dia");
            string pensamiento = Console.ReadLine();

            string ruta = "diario.txt";

            string data = $"{DateTime.Now}; {nombreusuario}; {pensamiento}";
            File.AppendAllText(ruta, data);

        }
    }
}
