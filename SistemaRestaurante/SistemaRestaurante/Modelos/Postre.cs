using SistemaRestaurante.Enums;
using SistemaRestaurante.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRestaurante.Modelos
{
    public class Postre:Plato,IPreparable
    {
        int CaloriasPorPorcion { get; set; }

        bool ContieneLactosa { get; set; }

        public Postre(string id, string nombre, string descripcion, decimal preciobase, TipoComida tipocomida, NivelDificultad dificultad, EstadoOrden estadoorden, int caloriasporporcion, bool contienelactosa) : base(id, nombre, descripcion, preciobase, tipocomida, dificultad, estadoorden)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.PrecioBase = preciobase;
            this.TipoComida = tipocomida;
            this.Dificultad = dificultad;
            this.EstadoOrden = estadoorden;
            this.CaloriasPorPorcion = caloriasporporcion;
            this.ContieneLactosa = contienelactosa;
        }

        public override void MostrarInformacionNutricional()
        {
            base.MostrarInformacionNutricional();
            Console.WriteLine("******");
            if (ContieneLactosa)
            {
                Console.WriteLine("SI contiene lactosa");
            }

            Console.WriteLine($"Calorias por porcion= {CaloriasPorPorcion}");
            Console.WriteLine("***************************************");
            CalcularCostoTotal();
        }

        public DateTime CalcularTiempoPreparacion()
        {
            DateTime tiempo = DateTime.Now;
            int minutos = 25;
            if (ContieneLactosa)
            {
                minutos += 5;

            }
            tiempo = tiempo.AddMinutes(minutos);
            Console.WriteLine($"Su pedido sale a las = {tiempo.ToString("HH:mm:ss")}");
            return tiempo;

        }

        public decimal CalcularCostoTotal()
        {
            Console.WriteLine("Precio");

            if (Dificultad == NivelDificultad.Facil)
            {
                Console.WriteLine(PrecioBase);
                return PrecioBase;
            }
            else if (Dificultad == NivelDificultad.Intermedio)
            {
                decimal PrecioFinal = PrecioBase;
                PrecioFinal = PrecioFinal * 2;
                Console.WriteLine(PrecioFinal);
                return PrecioFinal;
            }
            else if (Dificultad == NivelDificultad.Avanzado)
            {
                decimal PrecioFinal = PrecioBase;
                PrecioFinal = PrecioFinal * 4;
                Console.WriteLine(PrecioFinal);
                return PrecioFinal;
            }
            else
            {
                Console.WriteLine(PrecioBase);
                return PrecioBase;
            }
        }
        public void GenerarOrdenCocina()
        {
            ////VACIO////
        }
    }
}
