using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgIII.Ejercicios.Modelos
{
    public class Cancion : IReproductor
    {

        public string Nombre { get; set; }
        public string Artista { get; set; }

        public Cancion(string nombre, string artista)
        {
            Nombre = nombre;
            Artista = artista;

        }

        public void Play()
        {
            Console.WriteLine($"Reproduciendo cancion {Nombre} - {Artista}");
        }

        public void Stop()
        {
            Console.WriteLine($"Se detuvo la reproduccion de {Nombre} - {Artista}");
        }
    }
}
