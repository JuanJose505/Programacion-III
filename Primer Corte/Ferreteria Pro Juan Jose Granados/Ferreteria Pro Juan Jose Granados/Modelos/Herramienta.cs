using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Ferreteria_Pro_Juan_Jose_Granados.Enums;
using Ferreteria_Pro_Juan_Jose_Granados.Interfaces;

namespace Ferreteria_Pro_Juan_Jose_Granados.Modelos
{
    public class Herramienta : IGestionable
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }

        public TipoHerramienta TipoHerramienta { get; set; }

        public string ToCSV() => $"{Id};{Descripcion};{Precio};{TipoHerramienta}";

        public string ruta = "stock.csv";

        public Herramienta(int id, string descripcion, double precio, TipoHerramienta tipoherramienta)
        {
            this.Id = id;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.TipoHerramienta = tipoherramienta;
        }


        public static void Ejecutar()
        {
            bool menu = true;
            while (menu)
            {
                Console.WriteLine("1-Crear, 2-Listar, 3-Modificar, 4-Eliminar");
                int menuseleccion = int.Parse(Console.ReadLine());
                Herramienta h1 = new Herramienta(0,"",0,TipoHerramienta.Desconocido);
                if (menuseleccion == 1)
                {
                    h1.Crear();
                }
            }

        }

        public void Crear()
        {

            Console.WriteLine("Ingrese el ID de la herramienta");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la descripcion de la herramienta");
            string descripcion = Console.ReadLine();
            Console.WriteLine("Ingrese el precio de la herramineta");
            int precio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tipo de herramienta");
            Console.WriteLine("1-Manual, 2-Electrica, 3-Medicion");
            int tipoherramientamenu = int.Parse(Console.ReadLine());
            TipoHerramienta tipoherramienta;

            switch (tipoherramientamenu)
            {
                case 1:
                    {
                        Console.WriteLine(TipoHerramienta.Manual);
                        tipoherramienta = TipoHerramienta.Manual;
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine(TipoHerramienta.Electrica);
                        tipoherramienta = TipoHerramienta.Electrica;
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine(TipoHerramienta.Medicion);
                        tipoherramienta = TipoHerramienta.Medicion;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Valor ingresado no valido");
                        tipoherramienta = TipoHerramienta.Desconocido;
                        break;
                    }


            }

            Herramienta herramienta1 = new Herramienta(id, descripcion, precio, tipoherramienta);

            File.AppendAllText(ruta, herramienta1.ToCSV() + Environment.NewLine);
        }





        public void Leer()
        {
            Console.WriteLine(File.ReadAllText(ruta));
        }

        public void Actualizar()
        {
            Console.WriteLine("Ingrese el ID del articulo a actualizar");
            int id_actualizar = int.Parse(Console.ReadLine());
            string[] csv = File.ReadAllLines(ruta);
            for (int i = 0; i < csv.Length; i++)
            {
                string[] datos = csv[i].Split(';');
                int id = int.Parse(datos[0]);
                if (id == id_actualizar)
                {
                    Console.WriteLine("ID encontrado!");
                    Console.WriteLine("Ingrese la nueva descripcion");
                    string nuevades = Console.ReadLine();
                    Console.WriteLine("Ingrese el nuevo precio");
                    int nuevoprec = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el nuevo tipo");
                    Console.WriteLine("1-Manual, 2-Electrica, 3-Medicion");
                    int tipoherramientamenu = int.Parse(Console.ReadLine());
                    TipoHerramienta tipoherramienta;

                    switch (tipoherramientamenu)
                    {
                        case 1:
                            {
                                Console.WriteLine(TipoHerramienta.Manual);
                                tipoherramienta = TipoHerramienta.Manual;
                                break;
                            }

                        case 2:
                            {
                                Console.WriteLine(TipoHerramienta.Electrica);
                                tipoherramienta = TipoHerramienta.Electrica;
                                break;
                            }

                        case 3:
                            {
                                Console.WriteLine(TipoHerramienta.Medicion);
                                tipoherramienta = TipoHerramienta.Medicion;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Valor ingresado no valido");
                                tipoherramienta = TipoHerramienta.Desconocido;
                                break;
                            }


                    }

                    datos[1] = nuevades.ToString();
                    datos[2] = nuevoprec.ToString();
                    datos[3] = tipoherramienta.ToString();
                    csv[i] = string.Join(";", datos);
                    File.WriteAllLines(ruta, csv);


                }
            }
        }

        public void Eliminar()
        {
            Console.WriteLine("Ingrese el ID del articulo a eliminar");
            int id_eliminar = int.Parse(Console.ReadLine());
            string[] csv = File.ReadAllLines(ruta);
            List<string> nuevasLineas = new List<string>();
            for (int i = 0; i < csv.Length; i++)
            {
                string[] datos = csv[i].Split(';');
                int id = int.Parse(datos[0]);
                if (id != id_eliminar)
                {
                    nuevasLineas.Add(csv[i]);
                }

               
            }
            File.WriteAllLines(ruta, nuevasLineas);
        }
    }
}

