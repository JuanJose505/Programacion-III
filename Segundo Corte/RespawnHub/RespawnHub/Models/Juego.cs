using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RespawnHub.Models
{
    public class Juego
    {
        private static readonly string ruta = Path.Combine("db", "productos.csv");

        public int ID { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public int Logros { get; set; }

        public string Desarrollador { get; set; }

        public string RutaImagenSeleccionada { get; set; }

        public Juego() { }

        public void Crear(int id, string nombre, string descripcion, int logros, string desarrollador)
        {
            id = ID;
            nombre = Nombre;
            descripcion = Descripcion;
            logros = Logros;
            desarrollador = Desarrollador;
            


            

            string linea = $"{id},{nombre},{descripcion},{logros},{desarrollador}";

            string directorio = Path.GetDirectoryName(ruta);
            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }

            File.AppendAllText(ruta, linea + Environment.NewLine);
        }



    }
}
