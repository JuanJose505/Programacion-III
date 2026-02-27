using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjerciciosPOO.Modelos.Ejercicio1;

namespace EjerciciosPOO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-CuentaBancaria");
            int menu = int.Parse(Console.ReadLine());
            if (menu == 1)
            {
                CuentaBancaria cuenta = new CuentaBancaria("Alvaro", 100000);
                cuenta.ConsultarSaldo();
                cuenta.Depositar(30000);
                cuenta.Retirar(30000);
            }
        }
    }
}
