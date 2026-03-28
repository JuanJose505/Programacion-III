using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjerciciosPOO.Modelos.Ejercicio1;
using EjerciciosPOO.Modelos.Ejercicio2;
using EjerciciosPOO.Modelos.Ejercicio3;
using EjerciciosPOO.Modelos.Ejercicio4;
using EjerciciosPOO.Modelos.Ejercicio5;

namespace EjerciciosPOO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-Cuenta bancaria");
            Console.WriteLine("2-Control de inventario");
            Console.WriteLine("3-Calculadora de calificaciones");
            Console.WriteLine("4-Gestion de viajes");
            Console.WriteLine("5-Sala de Cine");

            int menu = int.Parse(Console.ReadLine());
            if (menu == 1)
            {
                CuentaBancaria cuenta = new CuentaBancaria("Alvaro", 100000);
                cuenta.ConsultarSaldo();
                cuenta.Depositar(30000);
                cuenta.Retirar(30000);
            }
            else if (menu == 2)
            {
                Producto producto = new Producto("Dorito", 2342, 4000);
                producto.AgregarStock(6);
                producto.VenderProducto(5);
                producto.MostrarInfo();

            }
            else if (menu == 3)
            {
                Programa colegio = new Programa();
                colegio.Ejecutar();
            }
            else if (menu == 4)
            {
                Vehiculo vehiculo1 = new Vehiculo("Ford", 80, 12);
                Vehiculo vehiculo2 = new Vehiculo("Mustang", 50, 10);
                vehiculo1.NecesitaCombustible(961);
                vehiculo2.NecesitaCombustible(800);
            }
            else if (menu == 5)
            {
                SalaCine sala1 = new SalaCine("Duro de matar", 50, 0, 10000);
                sala1.ComprarEntradas(5);
                sala1.VerDisponibilidad();
            }
        }
    }
}
