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
        public string Episodio { get; set; }

        public Podcast(string nombre, string artista, string episodio)
        {
            Nombre = nombre;
            Host = artista;
            Episodio = episodio;
        }

        public void Play()
        {
            Console.WriteLine($"Se reprodujo el podcast {Nombre} - {Episodio} - {Host}");
        }

        public void Stop()
        {
            Console.WriteLine($"Se detuvo el podcast {Nombre} - {Episodio} - {Host}");
        }

        public Podcast()
        {

        }
    }
}
