using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgIII.Ejercicios
{
    public class Gato : Mascota
    {
        public Gato(string nombre, int edad) : base(nombre, edad)
        {

        }

        public override void Hacertruco()
        {
            Console.WriteLine($"{Nombre} amasa un pan");
            Console.WriteLine($"{Nombre} tiene {Edad} Años");
        }
    }
}
