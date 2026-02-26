using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgIII.Ejercicios
{
    public class Loro : Mascota
    {
        public Loro(string nombre, int edad) : base(nombre, edad)
        {

        }

        public override void Hacertruco()
        {
            Console.WriteLine($"{Nombre} repite una frase random");
            Console.WriteLine($"{Nombre} tiene {Edad} Años");
        }
    }
}
