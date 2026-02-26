using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgIII.Ejercicios.Modelos
{
    public class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }

        public Producto(string nombre, double precio, int stock)
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;

        }

        public void Vender(int cantidad)
        {
            if (Stock >= cantidad)
            {
                Stock -= cantidad;
                double total = cantidad * Precio;
                Console.WriteLine($"Venta realizada, Total {total}");
                Console.WriteLine($"Stock restante {Stock}");
            }
            else Console.WriteLine("No hay suficiente stock:(");




        }
    }
}
