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
        private static readonly string ruta = Path.Combine("db", "juegos.csv");

        public int ID { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string Desarrollador { get; set; }

        public string RutaImagenSeleccionada { get; set; }

        public string RutaEjecutableSeleccionada { get; set; }

        public Juego() { }

        public void Crear(Juego juego) 
        {
            string linea = $"{juego.ID};{juego.Nombre};{juego.Descripcion};{juego.Desarrollador};{juego.RutaImagenSeleccionada};{juego.RutaEjecutableSeleccionada}";
            string directorio = Path.GetDirectoryName(ruta);
            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }

            File.AppendAllText(ruta, linea + Environment.NewLine);
        }

        public List<Juego> Listar()
        {
            List<Juego> juegos = new List<Juego>();

            if (File.Exists(ruta))
            {
                var lineas = File.ReadAllLines(ruta);

                foreach(var linea in lineas)
                {
                    var datos = linea.Split(';');
                    if (datos.Length == 6)
                    {
                        int id = int.Parse(datos[0]);
                        string nombre = datos[1];
                        string descripcion = datos[2];
                        string desarrollador = datos[3];
                        string rutaimagenseleccionada = datos[4];
                        string rutaejecutableseleccionada = datos[5];
                        Juego juego = new Juego();
                        juego.ID = id;
                        juego.Nombre = nombre;
                        juego.Descripcion = descripcion;
                        juego.Desarrollador = desarrollador;
                        juego.RutaImagenSeleccionada = rutaimagenseleccionada;
                        juego.RutaEjecutableSeleccionada = rutaejecutableseleccionada;

                        juegos.Add(juego);
                    }
                }

            }

            return juegos;
        } 


    }
}
