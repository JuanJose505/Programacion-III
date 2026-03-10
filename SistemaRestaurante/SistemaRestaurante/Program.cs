using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
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
            Ejecutar();
           
        }


        public static void Ejecutar()
        {   
            Console.WriteLine("Que tipo de plato pedira?");
            Console.WriteLine("1- Entrada");
            Console.WriteLine("2- Plato Principal");
            Console.WriteLine("3- Postre");
            int plato = int.Parse(Console.ReadLine());
            switch (plato)
            {
                case 1:
{
                        Console.WriteLine("Ingrese el id");
                        string id = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre de la entrada");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese la descripcion de la entrada");
                        string descripcion = Console.ReadLine();
                        Console.WriteLine("Ingrese el precio base de la entrada");
                        decimal preciobase = int.Parse(Console.ReadLine());
                        TipoComida tipo_comida = CalcularTipoComida();
                        NivelDificultad dificultad = CalcularDificultad();
                        EstadoOrden estado_orden = CalcularEstadoOrden();
                        Console.WriteLine("Es fria? Presione 1 para SI o cualquier numero para continuar");
                        bool esfria = false;
                        int fria = int.Parse(Console.ReadLine());
                        if (fria == 1)
                        {
                            esfria = true;
                        }
                        Console.WriteLine("Cuantas porciones tiene la entrada?");
                        int porciones = int.Parse(Console.ReadLine());
                        Entrada entrada1 = new Entrada(id, nombre, descripcion, preciobase, tipo_comida, dificultad, estado_orden, esfria,porciones);
                        entrada1.MostrarInformacionNutricional();
                        entrada1.CalcularTiempoPreparacion();
                        //Aqui termina de agregar todo a una lista que se imprimira en forma de recibo
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Ingrese el id");
                        string id = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre del plato principal");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese la descripcion del plato principal");
                        string descripcion = Console.ReadLine();
                        Console.WriteLine("Ingrese el precio base del plato principal");
                        decimal preciobase = int.Parse(Console.ReadLine());
                        TipoComida tipo_comida = CalcularTipoComida();
                        NivelDificultad dificultad = CalcularDificultad();
                        EstadoOrden estado_orden = CalcularEstadoOrden();
                        Console.WriteLine("Cual es la proteina principal del plato?");
                        string proteinaprincipal = Console.ReadLine();
                        Console.WriteLine("Incluye Guarnicion? Presione 1 para SI");
                        bool incluyeguarnicion = false;
                        int guarnicion = int.Parse(Console.ReadLine());
                        if (guarnicion == 1)
                        {
                            incluyeguarnicion = true;
                        }
                        PlatoPrincipal plato1 = new PlatoPrincipal(id, nombre, descripcion, preciobase, tipo_comida, dificultad, estado_orden, proteinaprincipal, incluyeguarnicion);
                        plato1.MostrarInformacionNutricional();
                        plato1.CalcularTiempoPreparacion();
                        // la esctructura es la misma solo cambiando detalles de cada plato
                        // ej, en este plato el condicional es la guarnicion
                        
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Ingrese el id");
                        string id = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre del postre");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese la descripcion del postre");
                        string descripcion = Console.ReadLine();
                        Console.WriteLine("Ingrese el precio base del postre");
                        decimal preciobase = int.Parse(Console.ReadLine());
                        TipoComida tipo_comida = CalcularTipoComida();
                        NivelDificultad dificultad = CalcularDificultad();
                        EstadoOrden estado_orden = CalcularEstadoOrden();
                        bool contienelactosa = false;
                        Console.WriteLine("Contiene lactosa? Presione 1 para SI");
                        int lactosa = int.Parse(Console.ReadLine());
                        if (lactosa == 1)
                        {
                            contienelactosa = true;
                        }
                        Console.WriteLine("Calorias por porcion");
                        int caloriasxporcion = int.Parse(Console.ReadLine());
                        Postre postre1 = new Postre(id, nombre, descripcion, preciobase, tipo_comida, dificultad, estado_orden, caloriasxporcion, contienelactosa);
                        postre1.MostrarInformacionNutricional();
                        postre1.CalcularTiempoPreparacion();
                        break;
                    }
            }
        }

        private static TipoComida CalcularTipoComida()
        {
            Console.WriteLine("Que tipo de comida escogera?");
            Console.WriteLine("1-Vegetariana");
            Console.WriteLine("2-Basico");
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
                        Console.WriteLine(TipoComida.Basico);
                        return TipoComida.Basico;
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

        private static NivelDificultad CalcularDificultad()
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


        private static EstadoOrden CalcularEstadoOrden()
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
