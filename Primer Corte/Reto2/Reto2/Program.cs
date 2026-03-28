using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Reto2.Modelos;

namespace Reto2
{
    public class Program    
    {
        static void Main(string[] args)
        {
            string ruta = "envios.csv";
            
            

            bool salir = true;
            while (salir)
            {
                Console.WriteLine("****SISTEMA GLOBALSHIP****");

                Console.WriteLine("1-Nuevo envio");
                Console.WriteLine("2-Ver peso total");
                Console.WriteLine("0-Salir");
                int menu = int.Parse(Console.ReadLine());
                if (menu == 1)
                {
                    Console.WriteLine("Ingrese la Guia");
                    int guia = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el nombre del destinatario");
                    string destinatario = Console.ReadLine();
                    Console.WriteLine("Ingrese el peso");
                    double peso = double.Parse(Console.ReadLine());
                    Tipo tiponcio = Consultartipo();
                    Paquete paquete = new Paquete(guia, destinatario, peso, tiponcio);
                    File.AppendAllText(ruta, paquete.ToCSV(S) + Environment.NewLine);
                    
                }
                else if (menu == 2)
                {
                    string[] lines = File.ReadAllLines(ruta);
                    double pesos = 0;
                    foreach (string line in lines)
                    {
                        string[] datos = line.Split(';');
                        pesos += double.Parse(datos[2]);
                        
                    }
                    Console.WriteLine("Peso total: " + pesos);
                }
                
                else if (menu == 0)
                {
                    Console.WriteLine("Gracias por usar mi programa!");
                    salir = false;

                }
                else
                {
                    Console.WriteLine("Dato ingresado no valido!");
                   
                }
                

            }

        }

        public static Tipo Consultartipo()
        {
            Console.WriteLine("Ingrese que tipo de envio es");
            Console.WriteLine("1-Nacional");
            Console.WriteLine("2-Internacional");
            int tipomenu = int.Parse(Console.ReadLine());
            switch (tipomenu)
            {
                case 1:
                    {
                        Console.WriteLine("Tipo ingresado: Nacional");
                        return Tipo.Nacional;
                    }
                case 2:
                    {
                        Console.WriteLine("Tipo ingresado: Internacional");
                        return Tipo.Internacional;

                    }
                default:
                    {
                        Console.WriteLine("Valor ingresado no valido");
                        return Tipo.Desconocido;
                    }
            }
        }
    }
}
