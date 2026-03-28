using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CreditodeVIviendaMiCasa
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor de la vivienda");
            double valorvivienda = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la tasa de interes mensual (%)");
            double tasainteresmensual = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el plazo en meses");
            int plazomeses = int.Parse(Console.ReadLine());

            double tasa = tasainteresmensual / 100;

            Console.WriteLine($"Monto: {valorvivienda} | Interes: {tasainteresmensual}% | Meses: {plazomeses}");

            DateTime fechapago = DateTime.Now;
            double saldo = valorvivienda;
            int whilemenu = 1;
            double capitalfinal = 0;
            double interesfinal = 0;

            
            double capital = valorvivienda / plazomeses;

            Console.WriteLine("---TABLA DE PAGOS ---");

            while (whilemenu <= plazomeses)
            {
                double interespormes = saldo * tasa;
                double cuota = capital + interespormes;
                saldo = saldo - capital;

                Console.WriteLine($"Mes {whilemenu} | {fechapago.AddMonths(whilemenu).ToShortDateString()} | Cap: ${capital} | Int: ${interespormes} | Saldo: ${saldo}");

                capitalfinal = capitalfinal + capital;
                interesfinal = interesfinal + interespormes;

                whilemenu += 1;
            }

            double total = capitalfinal + interesfinal;

            Console.WriteLine($"Total pagado: ${total} | Intereses: ${interesfinal}");
        }


    }
}
