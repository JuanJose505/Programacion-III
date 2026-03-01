using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO.Modelos.Ejercicio3
{
    public class Estudiante
    {
        string Nombre { get; set; }
        string Materia { get; set; }

        public List<double> Notas = new List<double>();


        public Estudiante (string nombre, string materia)
        {
            this.Nombre = nombre;
            this.Materia = materia;
            
        }

        public void AgregarNota(double nota)
        {
            Notas.Add(nota);
        }

        public double CalcularProm()
        {
            return Notas.Average();
        }

    }
}
