using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgIII.Ejercicios.Modelos
{
    public class VehiculoElectrico
    {
        int Bateria { get; set; }

        public VehiculoElectrico(int bateria)
        {
            Bateria = bateria;
        }

        public void Viajar()
        {
            Console.WriteLine("El vehiculo ha viajado, se ha restado 1% de bateria");
            Bateria -= 1;
            Console.WriteLine($"La bateria es de {Bateria}");
        }
    }
}
