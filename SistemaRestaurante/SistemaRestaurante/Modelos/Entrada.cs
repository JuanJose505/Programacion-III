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

        

        bool Esfria { get; set; }
        int Porciones { get; set; }


        protected Entrada(string id, string nombre, string descripcion, decimal preciobase, TipoComida tipocomida, NivelDificultad dificultad, EstadoOrden estadoorden, bool esfria, int porciones) : base(id, nombre, descripcion, preciobase, tipocomida, dificultad, estadoorden)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.PrecioBase = preciobase;
            this.TipoComida = tipocomida;
            this.Dificultad = dificultad;
            this.EstadoOrden = estadoorden;
        }

        public DateTime CalcularTiempoPreparacion()
        {
            DateTime tiempo = DateTime.Now.AddHours(2);
            return tiempo;
        }

        public void GenerarOrdenCocina()
        {
            Console.WriteLine("Nombre")
        }
    }
}
