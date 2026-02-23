using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgIII.Ejercicios
{
    public class Ejercicio1
    {
        public static void ejecutar()
        {

            Console.WriteLine("1. Perfil Gamer");
            Console.WriteLine("2. Calculadora de Propina");
            Console.WriteLine("3. Control de Aforo");
            Console.WriteLine("4. Generador de correo");
            Console.WriteLine("5.Simulador de semaforo");

            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                PerfilGamer();
            }
            else if (opcion == 2)
            {
                CalculadoradePropina();
            }
            else if (opcion == 3)
            {
                ControldeAforo();
            }
            else if (opcion == 4)
            {
                GeneradordeCorreo();
            }
            else if (opcion == 5)
            {
                SimuladordeSemaforo();
            }

            void PerfilGamer()
            {
                Console.WriteLine("Escribe tu nickname");
                string nickname = Console.ReadLine();

                Console.WriteLine("Ingrese su nivel (1-100)");
                int nivel = int.Parse(Console.ReadLine());

                Console.WriteLine("Es usted premium? (1-si 0-no)");
                int respuesta = int.Parse(Console.ReadLine());

                bool premium = false;

                if (respuesta == 1)
                {
                    premium = true;
                }
                else if (premium == false)
                {
                    Console.WriteLine("Lo sentimos, debe ser miembro premium para proseguir");
                    return;
                }

                Console.WriteLine("Gracias por confiar en nosotros:)");

                Console.WriteLine(" ");
                Console.WriteLine("Bienvenido" + " " + nickname);
                Console.WriteLine("Su nivel es de" + " " + nivel);


            }

            void CalculadoradePropina()
            {
                Console.WriteLine("Cuantos platos ordeno?");
                int platos = int.Parse(Console.ReadLine());

                int comida = 25000 * platos;

                Console.WriteLine("Que porcentaje de propina desea dejar? (1-10%  2-15%  3-20%)");
                int propina = int.Parse(Console.ReadLine());

                if (propina == 1)
                {
                    double vpropina = comida * 0.10;
                    double recibo = vpropina + comida;
                    Console.Write("Valor total del recibo: " + recibo);
                    if (recibo > 100000)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Muchas Gracias por apoyar nuestro negocio!");
                    }
                }
                else if (propina == 2)
                {
                    double vpropina = comida * 0.15;
                    double recibo = vpropina + comida;
                    Console.Write("Valor total del recibo: " + recibo);
                    if (recibo > 100000)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Muchas Gracias por apoyar nuestro negocio!");
                    }
                }
                else if (propina == 3)
                {
                    double vpropina = comida * 0.20;
                    double recibo = vpropina + comida;
                    Console.Write("Valor total del recibo: " + recibo);
                    if (recibo > 100000)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Muchas Gracias por apoyar nuestro negocio!");
                    }
                }
                else Console.WriteLine("Numero ingresado no valido");

            }

            void ControldeAforo()
            {
                int cupo = 50;
                while (cupo >= 0)
                {
                    Console.WriteLine("Ingrese el numero de personas a ingresar");
                    int personas = int.Parse(Console.ReadLine());
                    cupo -= personas;
                    if (cupo >= 0)
                    {
                        Console.WriteLine("Bienvenidos!");
                    }
                    else Console.WriteLine("No queda cupo, lo sentimos!");
                }

            }

            void GeneradordeCorreo()
            {
                Console.WriteLine("Ingrese su nombre");
                string nombre = Console.ReadLine().ToLower();
                Console.WriteLine("Ingrese su apellido");
                string apellido = Console.ReadLine().ToLower();

                string mailgen = nombre + "." + apellido + "@" + "unicesar.edu.co" +
                    "";
                Console.WriteLine("Su correo es: " + mailgen);

            }

            void SimuladordeSemaforo()
            {
                Console.WriteLine("De que color es el semaforo?");
                string color = Console.ReadLine().ToLower();
                if (color == "verde")
                {
                    Console.WriteLine("Sigue adelante!");
                }
                else if (color == "amarillo")
                {
                    Console.WriteLine("Preparate para frenar");
                }
                else if (color == "rojo")
                {
                    Console.WriteLine("Frena!");
                }
                else Console.WriteLine("Eso no es un color!");


            }

        }
    }
}
