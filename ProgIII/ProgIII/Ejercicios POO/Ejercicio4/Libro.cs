using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProgIII.Ejercicios.Modelos
{
    public class Libro
    {
        public string Nombre { get; set; }
        public string Autor { get; private set; }

        public bool Estado { get; set; }

        public Libro(string nombre, string autor, bool estado)
        {
            Nombre = nombre;
            Autor = autor;
            Estado = true;
        }

        public void Prestar()
        {
            if (Estado)
            {
                Estado = false;
                Console.WriteLine($"El libro {Nombre} del autor {Autor} ha sido prestado con exito!");
            }
            else
            {
                Console.WriteLine($"El libro {Nombre} del autor {Autor} no se puede prestar porque no hay unidades");
            }
        }
    }
}
