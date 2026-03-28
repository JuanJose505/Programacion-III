using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO.Modelos.Ejercicio3
{
    public class Programa
    {
        public void Ejecutar()
        {
            Console.WriteLine("ingrese el nombre");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la materia");
            string materia = Console.ReadLine();

            Estudiante estudiante = new Estudiante(nombre, materia);

            Console.WriteLine("Ingrese la nota 1");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota 2");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota 3");
            double nota3 = double.Parse(Console.ReadLine());

            estudiante.AgregarNota(nota1);
            estudiante.AgregarNota(nota2);
            estudiante.AgregarNota(nota3);

            Console.WriteLine($"Estudiante: {nombre} | Materia: {materia} | Promedio : {Math.Round(estudiante.CalcularProm(),2)} |");

        }
    }
}
