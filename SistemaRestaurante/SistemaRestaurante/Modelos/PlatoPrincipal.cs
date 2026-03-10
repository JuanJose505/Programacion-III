using SistemaRestaurante.Enums;
using SistemaRestaurante.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRestaurante.Modelos
{
    public class PlatoPrincipal : Plato, IPreparable
    {
        string ProteinaPrincipal { get; set; }
        bool IncluyeGuarnicion { get; set; }

        public PlatoPrincipal(string id, string nombre, string descripcion, decimal preciobase, TipoComida tipocomida, NivelDificultad dificultad, EstadoOrden estadoorden, string proteinaprincipal, bool incluyeguarnicion) : base(id, nombre, descripcion, preciobase, tipocomida, dificultad, estadoorden)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.PrecioBase = preciobase;
            this.TipoComida = tipocomida;
            this.Dificultad = dificultad;
            this.EstadoOrden = estadoorden;
            this.ProteinaPrincipal = proteinaprincipal;
            this.IncluyeGuarnicion = incluyeguarnicion;
        }


        public override void MostrarInformacionNutricional()
        {
            base.MostrarInformacionNutricional();
            Console.WriteLine("******");
            if (IncluyeGuarnicion)
            {
                Console.WriteLine("SI incluye guarnicion");
            }

            Console.WriteLine($"Proteina Principal= {ProteinaPrincipal}");
            Console.WriteLine("***************************************");
            CalcularCostoTotal();
        }
        public DateTime CalcularTiempoPreparacion()
        {
            DateTime tiempo = DateTime.Now;
            int minutos = 30 + ((int)Dificultad * 15);
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
