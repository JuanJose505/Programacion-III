using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;

namespace RespawnHub.Models
{
    public class Usuario
    {
        private static readonly string RUTA = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "usuarios.csv");

        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }

        public Usuario() { }


        public void GuardarLista(List<Usuario> lista)
        {
            List<string> lineas = new List<string>();

            foreach (var u in lista)
            {
                lineas.Add($"{u.ID};{u.Nombre};{u.Telefono};{u.Correo};{u.Direccion}");
            }

            File.WriteAllLines("usuarios.csv", lineas);
        }


        public void Crear(string id, string nombre, string telefono, string correo, string direccion)
        {
            string linea = $"{id};{nombre};{telefono};{correo};{direccion}";
            File.AppendAllText(RUTA, linea + Environment.NewLine);
        }

        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            if (File.Exists(RUTA))
            {
                var lineas = File.ReadAllLines(RUTA);

                foreach (var linea in lineas)
                {
                    var datos = linea.Split(';');

                    if (datos.Length == 5)
                    {
                        lista.Add(new Usuario
                        {
                            ID = datos[0],
                            Nombre = datos[1],
                            Telefono = datos[2],
                            Correo = datos[3],
                            Direccion = datos[4]
                        });
                    }
                }
            }

            return lista;
        }

        public Usuario Buscar(string id)
        {
            if (File.Exists(RUTA))
            {
                var lineas = File.ReadAllLines(RUTA);

                foreach (var linea in lineas)
                {
                    var datos = linea.Split(';');

                    if (datos.Length == 5 && datos[0] == id)
                    {
                        return new Usuario
                        {
                            ID = datos[0],
                            Nombre = datos[1],
                            Telefono = datos[2],
                            Correo = datos[3],
                            Direccion = datos[4]
                        };
                    }
                }
            }

            return null;
        }

        public void Eliminar(string id)
        {
            if (File.Exists(RUTA))
            {
                var lineas = File.ReadAllLines(RUTA);
                var nuevas = lineas.Where(l => !l.StartsWith(id + ";")).ToArray();
                File.WriteAllLines(RUTA, nuevas);
            }
        }

        public void Actualizar(string id, string nombre, string telefono, string correo, string direccion)
        {
         if (!File.Exists(RUTA)) { return; }

            var lineas = File.ReadAllLines(RUTA);

            for(int i = 0; i < lineas.Length; i++)
            {
                var datos = lineas[i].Split(';');

                if (datos[0] == id)
                {
                    lineas[i] = $"{id};{nombre};{telefono};{correo};{direccion}";
                    break;
                }
            }

            File.AppendAllLines(RUTA, lineas);

        }
    }
}