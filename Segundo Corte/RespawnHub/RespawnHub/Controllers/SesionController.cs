using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using RespawnHub.Models;

namespace RespawnHub.Controllers
{
    public class SesionController
    {
        
        public string Crear(string id, string fecha, string idjuego, string nombrejuego, string modo, string notas, int horas, string idusuario, string nombreusuario)
        {
            Sesion sesion = new Sesion();

            sesion.Crear(new Sesion
            {
                ID = id,
                Fecha = fecha,
                IDJuego = idjuego,
                NombreJuego = nombrejuego,
                Modo = modo,
                Notas = notas,
                Horas = horas,
                IDUsuario = idusuario,
                NombreUsuario = nombreusuario
            });

            return "ok";
        }

        public List<Sesion> Listar()
        {
            Sesion sesion = new Sesion();
            return sesion.Listar();
        }

        public string Eliminar(string id)
        {
            Sesion sesion = new Sesion();
            sesion.Eliminar(id);
            return "ok";

        }

        public int TotalHoras()
        {
            return Listar().Sum(s => s.Horas);
        }

        public string JuegoMasJugado()
        {
            var lista = Listar();
            if (lista.Count == 0) return "ninguno";

            return lista
                .GroupBy(s => s.NombreJuego)
                .OrderByDescending(g => g.Sum(s => s.Horas))
                .First().Key;
        }


        public int TotalSesiones()
        {
            return Listar().Count;
        }

        public double PromedioPorSesion()
        {
            var lista = Listar();
            if (lista.Count == 0) return 0;
            return lista.Average(s => s.Horas);
        }

        public int HorasJuegoMasJugado()
        {
            var lista = Listar();
            if (lista.Count == 0) return 0;

            return lista
                .GroupBy(s => s.NombreJuego)
                .OrderByDescending(g => g.Sum(s => s.Horas))
                .First()
                .Sum(s => s.Horas);
        }
    }
}
