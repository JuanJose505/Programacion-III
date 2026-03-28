using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgIII.Ejercicios
{
    public interface IReproductor
    {
        string Nombre { get; }
        void Play();
        void Stop();
    }
}
