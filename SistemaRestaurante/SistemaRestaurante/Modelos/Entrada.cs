using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRestaurante.Interfaces;

namespace SistemaRestaurante.Modelos
{
    public class Entrada:Plato, IPreparable
    {

        

        bool Esfria { get; set; }
        int Porciones { get; set; }


        protected Entrada(string id, string nombre, string descripcion, decimal preciobase, string tipocomida, string dificultad, bool esfria, int porciones) : base(id, nombre, descripcion, preciobase, tipocomida, dificultad)
        {

        }
    }
}
