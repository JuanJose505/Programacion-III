using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RespawnHub.Models
{
    public class Usuario
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }


        private string ruta = "usuarios.csv";

        public Usuario Buscar(string id)
        {
            if (!File.Exists(ruta))
            {
                return null;
            }

            string[] lineas = File.ReadAllLines(ruta);

            foreach (string linea in lineas)
            {
                var campo = linea.Split(';');

                if (campo[0] == id)
                {
                    return new Usuario
                    {
                        ID = campo[0],
                        Nombre = campo[1],
                        Telefono = campo[2],
                        Correo = campo[3],
                        Direccion = campo[4]
                    };


                }
            }

            return null;
        }


        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            if (!File.Exists(ruta)) return lista;

            var lineas = File.ReadLines(ruta);

            foreach (string linea in lineas)
            {
                var campos = linea.Split(';');

                lista.Add(new Usuario
                {
                    ID = campos[0],
                    Nombre = campos[1],
                    Telefono = campos[2],
                    Correo = campos[3],
                    Direccion = campos[4]
                });
            }

            return lista;
        }


        public void Crear()
        {
            string texto = $"{ID};{Nombre};{Telefono};{Correo};{Direccion}";
            File.AppendAllText(ruta,texto + Environment.NewLine);
        }


        public void Eliminar(string id)
        {
            var lista = Listar();

            List<Usuario> nuevalista = new List<Usuario>();
            
            foreach (Usuario u in lista)
            {
                if (u.ID != id)
                {
                    nuevalista.Add(u);
                }

                List<string> lineas = new List<string>();

                foreach (string linea in lineas)
                {
                    lineas.Add($"{u.ID};{u.Nombre};{u.Telefono};{u.Correo};{u.Direccion}");
                }

                File.WriteAllLines(ruta, lineas);
            }


        }
    }
}
