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
        public string Crear(Usuario usuario)
        {
            Usuario model = new Usuario();

            if (model.Buscar(usuario.ID) != null)
            {
                return "El usuario con ese ID ya existe";
            }

            usuario.Crear();
            return "ok";

        }
    }
        
}
