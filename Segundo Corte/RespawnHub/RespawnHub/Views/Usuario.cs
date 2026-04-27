using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using RespawnHub.Controllers;
using RespawnHub.Models;

namespace RespawnHub.Forms
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool validateID = false;
            bool validateNombre = false;
            bool validateTelefono = false;
            bool validateCorreo = false;
            bool validateDireccion = false;
            bool validate = false;


            if (txtID.Text != "")
            {
                validateID = true;
            }
            if (txtNombre.Text != "")
            {
                validateNombre = true;
            }
            if (mtxtTelefono.Text != "")
            {
                validateTelefono = true;
            }
            if (txtCorreo.Text != "")
            {
                validateCorreo = true;
            }
            if (txtDireccion.Text != "")
            {
                validateDireccion = true;
            }

            if (validateID && validateNombre && validateTelefono && validateCorreo && validateDireccion)
            {
                validate = true;

            }

            if (validate)
            {
                Usuario usuario = new Usuario()
                {
                    ID = txtID.Text,
                    Nombre = txtNombre.Text,
                    Telefono = mtxtTelefono.Text,
                    Correo = txtCorreo.Text,
                    Direccion = txtDireccion.Text
                
                };

                UsuarioController controller = new UsuarioController();
                bool resultado = controller.Guardar(usuario);
                if (resultado)
                {
                    MessageBox.Show("Usuario registrado con exito");
                    CargarUsuarios();
                }
                else
                {
                    MessageBox.Show("Error al ingresar, datos ya existentes");
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            mtxtTelefono.Clear();
            txtCorreo.Clear();
        }

        private void CargarUsuarios()
        {
            dgvUsuarios.Rows.Clear();

            if (!File.Exists("usuarios.csv"))
            {
                return;
            }

            string[] lineas = File.ReadAllLines("usuarios.csv");
            foreach (string linea in lineas)
            {
                string[] parte = linea.Split(';');

                dgvUsuarios.Rows.Add(

                    parte[0],
                    parte[1],
                    parte[2],
                    parte[3],
                    parte[4]

                    );

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
           




        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una fila para realizar la accion");
                return;
            }

            string id = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();

            UsuarioController controller = new UsuarioController();

            bool resultado = controller.Borrar(id);

            if (resultado)
            {
                MessageBox.Show("Valor eliminado con exito");
                CargarUsuarios();

            }
            else
            {
                MessageBox.Show("Error al intenar realizar la accion");
            }


        }

        public void BuscarUsuarios(string texto)
        {
            dgvUsuarios.Rows.Clear();

            UsuarioController controller = new UsuarioController();

            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarUsuarios(txtBuscar.Text);
        }

    }
}
