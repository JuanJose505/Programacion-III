using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgIII.Ejercicios;
using ProgIII.Ejercicios.Modelos;

namespace ProgIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desea ejecutar los ejercicios basicos o los POO? 1-Basicos 2-POO");
            int menu1 = int.Parse(Console.ReadLine());
            if (menu1 == 1)
            {
                Ejercicio1.ejecutar();
            }
            else if (menu1 == 2)
            {
                Console.WriteLine("1-Sistema de mascotas virtuales");
                Console.WriteLine("2-Gestion de inventario de tienda");
                Console.WriteLine("3-Reproductor de multimedia");
                Console.WriteLine("4-Sistema de biblioteca");
                Console.WriteLine("5-Control de vehiculos electricos");
                int opcion_menu = int.Parse(Console.ReadLine());

                if (opcion_menu == 1)
                {
                    Console.WriteLine("Que animal desea crear?");
                    Console.WriteLine("1-Gato");
                    Console.WriteLine("2-Loro");
                    int opcion = int.Parse(Console.ReadLine());

                    if (opcion == 1)
                    {
                        Console.WriteLine("Que nombre desea para el Gato?");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Que edad desea para el Gato?");
                        int edad = int.Parse(Console.ReadLine());
                        Mascota a = new Gato($"{nombre}", edad);
                        a.Hacertruco();
                    }
                    else if (opcion == 2)
                    {
                        Console.WriteLine("Que nombre desea para el Loro?");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Que edad desea para el Loro?");
                        int edad = int.Parse(Console.ReadLine());
                        Mascota b = new Loro($"{nombre}", edad);
                        b.Hacertruco();
                    }

                }
                else if (opcion_menu == 2)
                {
                    Producto producto = null;
                    bool continuar = true;
                    while (continuar)
                    {


                        Console.WriteLine("1-Ingresar productos al sistema 2-Vender productos");
                        int opcion = int.Parse(Console.ReadLine());

                        if (opcion == 1)
                        {
                            Console.WriteLine("Ingrese el nombre del producto a ingresar");
                            string n = Console.ReadLine();
                            Console.WriteLine("Ingrese el precio del producto a ingresar");
                            int p = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el stock del producto (cantidad)");
                            int s = int.Parse(Console.ReadLine());

                            producto = new Producto(n, p, s);
                        }
                        else if (opcion == 2)
                        {
                            if (producto == null)
                            {
                                Console.WriteLine("No hay productos en sistema");
                            }
                            else
                            {
                                Console.WriteLine("Ingrese cantidad a vender");
                                int c = int.Parse(Console.ReadLine());
                                producto.Vender(c);



                            }

                        }
                        Console.WriteLine("Desea continuar? (s/n)");
                        string respuesta = Console.ReadLine().ToLower();
                        if (respuesta == "n")
                        {
                            Console.WriteLine("Gracias por usar mi programa!");
                            continuar = false;
                        }

                    }

                }
                else if (opcion_menu == 3)
                {

                    Console.WriteLine("1- Cancion 2- Podcast");
                    int opcion = int.Parse(Console.ReadLine());
                    if (opcion == 1)
                    {
                        IReproductor cancion = new Cancion("Call it fate, Call it karma", "The strokes");
                        cancion.Play();
                        Console.ReadLine();
                        Console.WriteLine($"Desea pausar {cancion.Nombre}? 1-SI 2-NO");
                        int decision = int.Parse(Console.ReadLine());
                        if (decision == 1)
                        {
                            cancion.Stop();
                        }
                        else if (decision == 2)
                        {
                            cancion.Play();
                            Console.ReadLine();
                        }
                        else Console.WriteLine("Valor ingresado no valido, saliendo...");
                    }
                    else if (opcion == 2)
                    {
                        IReproductor podcast = new Podcast("CHARLA CON UN SOLDADO DE FORTUNA| Lo que se siente al matar cara a cara, Estrés PostTraumatico", "Jordi Wild");
                        podcast.Play();
                        Console.ReadLine();
                        Console.WriteLine($"Desea pausar {podcast.Nombre}? 1-SI 2-NO");
                        int decision = int.Parse(Console.ReadLine());
                        if (decision == 1)
                        {
                            podcast.Stop();
                        }
                        else if (decision == 2)
                        {
                            podcast.Play();
                            Console.ReadLine();
                        }
                        else Console.WriteLine("Valor ingresado no valido, saliendo...");
                    }
                    else Console.WriteLine("Valor ingresado no valido");
                }
                else if (opcion_menu == 4)
                {
                    Console.WriteLine("Ingrese el nombre del libro a buscar prestado");
                    string n_libro = Console.ReadLine();
                    Console.WriteLine("Ingrese el autor del libro que acaba de ingresar");
                    string a_libro = Console.ReadLine();
                    Libro libro = new Libro(n_libro, a_libro, true);
                    libro.Prestar();

                    Console.WriteLine("Ingrese el nombre del libro a buscar prestado");
                    string n2_libro = Console.ReadLine();
                    Console.WriteLine("Ingrese el autor del libro que acaba de ingresar");
                    string a2_libro = Console.ReadLine();
                    Libro libro2 = new Libro(n_libro, a_libro, true);

                    libro.Prestar();
                }
                else if (opcion_menu == 5)
                {
                    bool exit = true;
                    VehiculoElectrico carraso = new VehiculoElectrico(100);
                    while (exit)
                    {
                        carraso.Viajar();
                        Console.WriteLine("Si quieres dejar de viajar presione *");
                        string decisionviaje = Console.ReadLine();
                        if (decisionviaje == "*")
                        {
                            return;
                        }

                    }


                }
            }



            }
        }
    }

