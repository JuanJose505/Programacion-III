using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgIII.Ejercicios
{
    public class Mascota
    {
        public string Nombre;

        public int Edad;

        public Mascota(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        
        public virtual void Hacertruco()
        {

        }
    }
}
