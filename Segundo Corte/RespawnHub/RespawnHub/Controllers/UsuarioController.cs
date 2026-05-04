using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RespawnHub.Models;

namespace RespawnHub.Controllers
{
    public class UsuarioController
    {

        public string Crear(string id, string nombre, string telefono, string correo, string direccion)
        {
            Usuario usuario = new Usuario();

            if (id == "")
            {
                return "Error al ingresar usuario";
            }

            if (nombre == "")
            {
                return "Error al ingresar usuario";
            }

            if (telefono == "")
            {
                return "Error al ingresar usuario";
            }

            if (correo == "")
            {
                return "Error al ingresar usuario";
            }

            if (direccion == "")
            {
                return "Error al ingresar usuario";
            }

            if (usuario.Buscar(id) != null)
            {
                return "El usuario con ese ID ya existe";
            }

            if (!correo.Contains("@") || !correo.Contains(".com"))
            {
                return "El correo no es valido, ingrese un correo valido";
            }

            usuario.Crear(id, nombre, telefono, correo, direccion);
            return "ok";
        }

        public List<Usuario> Listar()
        {
            Usuario usuario = new Usuario();
            return usuario.Listar();
        }

        public string Eliminar(string id)
        {
            Usuario usuario = new Usuario();

            if (usuario.Buscar(id) == null)
            {
                return "El usuario no existe";
            }

            usuario.Eliminar(id);
            return "ok";
        }

        public string Actualizar(string id, string nombre, string telefono, string correo, string direccion)
        {
            Usuario usuario = new Usuario();

            if (usuario.Buscar(id) == null)
            {
                return "El usuario no existe";
            }

            usuario.Actualizar(id, nombre, telefono, correo, direccion);
            return "ok";
        }
        public void GuardarLista(List<Usuario> lista)
        {
            Usuario usuario = new Usuario();
            usuario.GuardarLista(lista);
        }
    }
}