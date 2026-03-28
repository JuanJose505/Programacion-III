using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto2.Modelos
{
    public class Paquete
    {
        public int Guia { get; set; }
        public string Destinatario { get; set; }
        public double Peso { get; set; }
        
        public Tipo Tipo { get; set; }

        public string ToCSV() => $"{Guia};{Destinatario};{Peso};{Tipo}";
        public Paquete (int guia, string destinatario, double peso, Tipo tipo)
        {
            this.Guia = guia;
            this.Destinatario = destinatario;
            this.Peso = peso;
            this.Tipo = tipo;

        }
        

    }
}
