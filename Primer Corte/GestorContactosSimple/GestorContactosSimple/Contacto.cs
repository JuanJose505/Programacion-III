using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GestorContactosSimple
{
    public class Contacto
    {
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }

        public string ToCSV() => $"{Nombre};{Telefono};{Correo}";
        public Contacto(string nombre, int telefono, string correo)
        {
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Correo = correo;
        }

        public static void Ejecutar()
        {
            bool salir = true;
            string ruta = "contactos.csv";
            while (salir)
            {
                Console.Clear();
                Console.WriteLine("****Bienvenido a mi programa de mierda!*****");
                Console.WriteLine("Que desea hacer cara de pinga?");
                Console.WriteLine("1- Ingresar un nuevo contacto");
                Console.WriteLine("2- Listar contactos");
                Console.WriteLine("3- Salir");
                int menu = int.Parse(Console.ReadLine());
                    
                if (menu == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese el nombre");
                    string nombre = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Ingrese el telefono");
                    int telefono = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Ingrese el correo");
                    string correo = Console.ReadLine();
                    Console.Clear();
                    string correomedio = correo.ToLower();
                    string correofinal = correomedio.Trim();
                    Contacto contacto1 = new Contacto(nombre, telefono, correofinal);
                    File.AppendAllText(ruta, contacto1.ToCSV() + Environment.NewLine);
                }
                else if (menu == 2)
                {
                    Console.Clear();
                    string[] lines = File.ReadAllLines(ruta);
                    foreach (string line in lines)
                    {
                        string[] datos = line.Split(';');
                        Console.WriteLine(line);
                       
                    }
                    Console.ReadLine();
                    
                }
                else if (menu == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Gracias por usar mi programa de mierda!");
                    salir = false;
                }
            }
           


            

        }
    }
}

