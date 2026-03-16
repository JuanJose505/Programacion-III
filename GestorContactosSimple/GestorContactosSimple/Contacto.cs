using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GestorContactosSimple
{
    public class Contacto
    {
        string Nombre { get; set; }
        int Telefono { get; set; }
        string Correo { get; set; }

        public string ToCSV() => $"{Nombre};{Telefono};{Correo}";
        

        public Contacto (string nombre, int telefono, string correo)
        {
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Correo = correo;
            
        }

        public static void ToCSV()
        {
            string ruta = "contactos.csv";
            
            Contacto contacto = new Contacto { Nombre = ""}

            
        }
    }
}
