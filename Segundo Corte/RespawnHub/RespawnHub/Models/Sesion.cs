using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RespawnHub.Models
{
    public class Sesion
    {
        private static readonly string RUTA = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db", "sesiones.csv");

        public string ID { get; set; }

        public string Fecha { get; set; }

        public string IDJuego { get; set; }

        public string NombreJuego { get; set; }

        public string Modo { get; set; }

        public string Notas { get; set; }
        public int Horas { get; set; }

        public string IDUsuario { get; set; }

        public string NombreUsuario { get; set; }

        public Sesion() { }

        public void Crear(Sesion s)
        {
            string linea = $"{s.ID};{s.Fecha};{s.IDJuego};{s.NombreJuego};{s.Modo};{s.Notas};{s.Horas};{s.IDUsuario};{s.NombreUsuario}";
            string directorio = Path.GetDirectoryName(RUTA);
            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }
            File.AppendAllText(directorio, linea + Environment.NewLine);
        }

        public List<Sesion> Listar()
        {
            List<Sesion> lista = new List<Sesion>();

            if (!File.Exists(RUTA)) return lista;

            string[] lineas = File.ReadAllLines(RUTA);

            foreach (var linea in lineas)
            {
                string[] campo = linea.Split(';');
                if (campo.Length == 9)
                {
                    lista.Add(new Sesion
                    {
                        ID = campo[0],
                        Fecha = campo[1],
                        IDJuego = campo[2],
                        NombreJuego = campo[3],
                        Modo = campo[4],
                        Notas = campo[5],
                        Horas = int.Parse(campo[6]),
                        IDUsuario = campo[7],
                        NombreUsuario = campo[8],
                    });
                }
            }
            return lista;
        }


        public void Eliminar (string id)
        {
            if (!File.Exists(RUTA)) return;

            string[] lineas = File.ReadAllLines(RUTA);
            var nuevas = new List<string>();

            foreach (var linea in lineas)
            {
                var campos = linea.Split(';');
                if (campos.Length == 9 && campos[0] == id)
                {
                    nuevas.Add(linea);
                }
            }
            File.WriteAllLines(RUTA, nuevas);


        }
    }
}
