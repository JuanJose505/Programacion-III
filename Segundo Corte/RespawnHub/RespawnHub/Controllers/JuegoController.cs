using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RespawnHub.Models;

namespace RespawnHub.Controllers
{
    public class JuegoController
    {
        private List<Juego> listajuegos = new List<Juego>();

        public string RegistrarJuego(int id, string nombre, string descripcion, string desarrollador, string rutaImagenSeleccionada, string rutaEjecutableSeleccionada)
        {
            Juego item = new Juego();

            item.ID = id;
            item.Nombre = nombre;
            item.Descripcion = descripcion;
            item.Desarrollador = desarrollador;
            item.RutaImagenSeleccionada = CopiarImagen(rutaImagenSeleccionada, nombre);
            item.RutaEjecutableSeleccionada = rutaEjecutableSeleccionada;

            item.Crear(item);

            return "ok";
        }

        private string CopiarImagen(string rutaOrigen, string nombreFoto)
        {
            if(rutaOrigen == "")
            {
                return "";
            }

            string carpetaDestino = Path.Combine(Application.StartupPath, "images");

            if (!Directory.Exists(carpetaDestino))
                Directory.CreateDirectory(carpetaDestino);

            string nombreArchivo = $"{nombreFoto}{Path.GetExtension(rutaOrigen)}";

            string rutaDestino = Path.Combine(carpetaDestino, nombreArchivo);

            File.Copy(rutaOrigen, rutaDestino, true);

            return nombreArchivo;

        }

        public List<Juego> ObtenerJuegos()
        {
            return listajuegos;
        }
        
    }
}
