using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO.Modelos.Ejercicio1
{
    public class CuentaBancaria
    {
        string Titular { get; set; }
        decimal Saldo { get; set; }

        public CuentaBancaria(string titular, decimal saldo)
        {
            this.Titular = titular;
            this.Saldo = saldo;
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine($"El saldo del usuario {Titular} es de {Saldo}");
        }

        public void Depositar(decimal cantidad)
        {
            if (cantidad >= 1)
            {
                Saldo += cantidad;
                Console.WriteLine($"Deposito exitoso, el saldo actual es de {Saldo}");
            }
            else
            {
                Console.WriteLine("La cantidad es negativa, no se puede continuar");
            }

        }

        public void Retirar(decimal cantidad)
        {
            if (Saldo >= cantidad)
            {
                Saldo -= cantidad;
                Console.WriteLine($"Retiro exitoso, saldo actual {Saldo}");
            }
            else
            {
                Console.WriteLine("El saldo no es suficiente para continuar");
            }
        }
    }
}
