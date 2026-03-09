using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using ConcesionarioVehiculos.Enums;
using ConcesionarioVehiculos.Interfaces;
using ConcesionarioVehiculos.Modelos;

namespace ConcesionarioVehiculos
{
    public class Program
    {
        static void Main(string[] args)
        {
            HacerCompra();
        }

        public static void HacerCompra()
        {
            List<IVendible> lista = new List<IVendible>();
            bool menuu = true;
            while (menuu)
            {
                Console.WriteLine("*********BIENVENIDO A LA MEJOR CONSECIONARIA DE AGUACHICA!***********");
                Console.WriteLine("Ingrese la opción de vehiculo que desea vender");
                Console.WriteLine("1- Motocicleta");
                Console.WriteLine("2- Auto");
                Console.WriteLine("3- Camion");
                Console.WriteLine("4- Generar factura");
                int menu = int.Parse(Console.ReadLine());
                if (menu == 1)
                {
                    Console.WriteLine("Ingrese la placa (ID) de la motocicleta");
                    string id = Console.ReadLine();

                    Console.WriteLine("Ingrese la marca de la motocicleta");
                    string marca = Console.ReadLine();

                    Console.WriteLine("Ingrese el modelo de la motocicleta");
                    string modelo = Console.ReadLine();

                    Console.WriteLine("Ingrese el año de la motocicleta");
                    int year = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el Precio base de la motocicleta");
                    decimal preciobase = decimal.Parse(Console.ReadLine());

                    TipoCombustible combustible = ElegirTipoCombustible();

                    EstadoVehiculo estadovehiculo = ElegirEstadoVehiculo();

                    Console.WriteLine("Ingrese el Cilindraje de la motocicleta");
                    int cilindraje = int.Parse(Console.ReadLine());

                    bool deportiva = false;

                    Console.WriteLine("Es deportiva? 1-si 2-no");
                    int deportivaif = int.Parse(Console.ReadLine());

                    switch (deportivaif)
                    {
                        case 1:
                            {
                                deportiva = true;
                                break;
                            }
                        case 2:
                            {
                                break;
                            }
                    }

                    Motocicleta moto1 = new Motocicleta(id, marca, modelo, year, preciobase, combustible, estadovehiculo, cilindraje, deportiva);
                    lista.Add(moto1);
                }
                else if (menu == 2)
                {
                    Console.WriteLine("Ingrese el ID del auto");
                    string id = Console.ReadLine();

                    Console.WriteLine("Ingrese la marca del auto ");
                    string marca = Console.ReadLine();

                    Console.WriteLine("Ingrese el modelo del auto");
                    string modelo = Console.ReadLine();

                    Console.WriteLine("Ingrese el año del auto");
                    int year = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el Precio base del auto");
                    decimal preciobase = decimal.Parse(Console.ReadLine());

                    TipoCombustible combustible = ElegirTipoCombustible();

                    EstadoVehiculo estadovehiculo = ElegirEstadoVehiculo();

                    Console.WriteLine("Ingrese el numero de puertas del auto");
                    int numeropuertas = int.Parse(Console.ReadLine());

                    bool aireacondicionado = false;
                    Console.WriteLine("Tiene aire acondicionado el auto? 1-Si 2-No");
                    int aireacondicionadomenu = int.Parse(Console.ReadLine());
                    if (aireacondicionadomenu == 1)
                    {
                        aireacondicionado = true;
                    }

                    Auto auto1 = new Auto(id, marca, modelo, year, preciobase, combustible, estadovehiculo, numeropuertas, aireacondicionado);
                    lista.Add(auto1);
                }
                else if (menu == 3)
                {
                    Console.WriteLine("Ingrese el ID del camion");
                    string id = Console.ReadLine();

                    Console.WriteLine("Ingrese la marca del camion ");
                    string marca = Console.ReadLine();

                    Console.WriteLine("Ingrese el modelo del camion");
                    string modelo = Console.ReadLine();

                    Console.WriteLine("Ingrese el año del camion");
                    int year = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el Precio base del camion");
                    decimal preciobase = decimal.Parse(Console.ReadLine());

                    TipoCombustible combustible = ElegirTipoCombustible();

                    EstadoVehiculo estadovehiculo = ElegirEstadoVehiculo();

                    Console.WriteLine("Ingrese la capacidad de carga del camion (Kilogramos)");
                    decimal capacidadcarga = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el numero de ejes que contiene el camion");
                    int numeroejes = int.Parse(Console.ReadLine());

                    Camion camion1 = new Camion(id, marca, modelo, year, preciobase, combustible, estadovehiculo, capacidadcarga, numeroejes);
                    lista.Add(camion1);
                }
                else if (menu == 4)
                {
                    foreach (IVendible vehiculo in lista)
                    {
                        vehiculo.GenerarFacturaVenta();
                        Console.WriteLine("");
                        Console.WriteLine("");
                        menuu = false;
                    }
                }
            }

        }



        private static EstadoVehiculo ElegirEstadoVehiculo()
        {
            Console.WriteLine("En que estado se encuentra el vehiculo? 1-Nuevo 2-Usado 3-Seminuevo");
            int estadoswitch = int.Parse(Console.ReadLine());
            switch (estadoswitch)
            {
                case 1:
                    {
                        Console.WriteLine(EstadoVehiculo.Nuevo);
                        return EstadoVehiculo.Nuevo;
                    }
                case 2:
                    {
                        Console.WriteLine(EstadoVehiculo.Usado);
                        return EstadoVehiculo.Usado;
                    }
                case 3:
                    {
                        Console.WriteLine(EstadoVehiculo.Seminuevo);
                        return EstadoVehiculo.Seminuevo;
                    }
                default:
                    {
                        Console.WriteLine(EstadoVehiculo.Desconocido);
                        return EstadoVehiculo.Desconocido;
                    }
            }
        }
        public static TipoCombustible ElegirTipoCombustible()
        {
            Console.WriteLine("Que tipo de combustible tiene el vehiculo? 1-Gasolina 2-Diesel 3-Electrico 4-Hibrido");
            int combustibleswitch = int.Parse(Console.ReadLine());
            switch (combustibleswitch)
            {
                case 1:
                    {
                        Console.WriteLine(TipoCombustible.Gasolina);
                        return TipoCombustible.Gasolina;
                    }
                case 2:
                    {
                        Console.WriteLine(TipoCombustible.Diesel);
                        return TipoCombustible.Diesel;
                    }
                case 3:
                    {
                        Console.WriteLine(TipoCombustible.Electrico);
                        return TipoCombustible.Electrico;
                    }
                case 4:
                    {
                        Console.WriteLine(TipoCombustible.Hibrido);
                        return TipoCombustible.Hibrido;
                    }
                default:
                    {
                        Console.WriteLine(TipoCombustible.Desconocido);
                        return TipoCombustible.Desconocido;
                    }
            }


        }
        
       


    }
}
