using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO.Modelos.Ejercicio2
{
    public class Producto
    {
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public int Precio { get; set; }
        public int CantidadStock { get; set; }

        public Producto(string nombre, int codigo, int precio)
        {
            this.Nombre = nombre;
            this.Codigo = codigo;
            this.Precio = precio;
        }

        public void AgregarStock(int cantidad)
        {
            CantidadStock += cantidad;
            Console.WriteLine($"Producto agregado a stock con exito!");
        }
        

        public void VenderProducto(int cantidad)
        {
            CantidadStock -= cantidad;
            Console.WriteLine($"Producto vendido, total de la venta {Precio * cantidad}");
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Cantidad de stock total = {CantidadStock}");
            Console.WriteLine($"Nombre del producto = {Nombre}");
            Console.WriteLine($"Codigo del producto = {Codigo}");
            Console.WriteLine($"Precio del producto = {Precio}");
        }
        
    }
}
