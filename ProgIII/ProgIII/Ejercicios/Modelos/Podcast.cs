using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgIII.Ejercicios.Modelos
{
    public class Podcast : IReproductor
    {
        public string Nombre { get; set; }
        public string Host { get; set; }

        public Podcast(string nombre, string artista)
        {
            Nombre = nombre;
            Host = artista;
        }

        public void Play()
        {
            Console.WriteLine($"Se reprodujo el podcast {Nombre} - {Host}");
        }

        public void Stop()
        {
            Console.WriteLine($"Se detuvo el podcast {Nombre} - {Host}");
        }
    }
}
