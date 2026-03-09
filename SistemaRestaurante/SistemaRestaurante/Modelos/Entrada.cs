using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRestaurante.Enums;
using SistemaRestaurante.Interfaces;

namespace SistemaRestaurante.Modelos
{
    public class Entrada:Plato, IPreparable
    {

        public bool Esfria { get; set; }
        public int Porciones { get; set; }


        public Entrada(string id, string nombre, string descripcion, decimal preciobase, TipoComida tipocomida, NivelDificultad dificultad, EstadoOrden estadoorden, bool esfria, int porciones) : base(id, nombre, descripcion, preciobase, tipocomida, dificultad, estadoorden)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.PrecioBase = preciobase;
            this.TipoComida = tipocomida;
            this.Dificultad = dificultad;
            this.EstadoOrden = estadoorden;
            this.Esfria = esfria;
            this.Porciones = porciones;
        }

        public DateTime CalcularTiempoPreparacion()
        {
            DateTime tiempo = DateTime.Now;

            if (Esfria)
            {
                tiempo = tiempo.AddMinutes(10);
                Console.WriteLine($"El tiempo de preparacion es de= {tiempo}");
                return tiempo;
            } 
            else 
            {
                tiempo = tiempo.AddMinutes(20);
                Console.WriteLine($"El tiempo es de {tiempo}");
                return tiempo;
            } 

        }

        public void GenerarOrdenCocina()
        {
            /////VACIO////
        }

        public override void MostrarInformacionNutricional()
        {
            base.MostrarInformacionNutricional();

            Console.WriteLine("******");
            if (Esfria)
            {
                Console.WriteLine("Es Fria");
            }

            Console.WriteLine($"Porciones = {Porciones}");
            Console.WriteLine("***************************************");
            CalcularCostoTotal();
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
        
    }
}
