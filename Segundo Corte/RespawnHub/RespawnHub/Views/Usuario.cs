using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using RespawnHub.Controllers;
using RespawnHub.Models;


namespace RespawnHub.Forms
{
    public partial class Usuarios : Form
    {
        private UsuarioController _controller = new UsuarioController();

        public Usuarios()
        {
            InitializeComponent();

            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.Columns[0].DataPropertyName = "ID";
            dgvUsuarios.Columns[1].DataPropertyName = "Nombre";
            dgvUsuarios.Columns[2].DataPropertyName = "Telefono";
            dgvUsuarios.Columns[3].DataPropertyName = "Correo";
            dgvUsuarios.Columns[4].DataPropertyName = "Direccion";

            this.Load += Usuarios_Load;
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = _controller.Listar();
        }

        private void LimpiarCampos()
        {
            txtID.Clear();
            txtNombre.Clear();
            mtxtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string resultado = _controller.Crear(
                txtID.Text,
                txtNombre.Text,
                mtxtTelefono.Text,
                txtCorreo.Text,
                txtDireccion.Text
            );

            if (resultado == "ok")
            {
                MessageBox.Show("Usuario registrado con éxito");
                CargarUsuarios();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show(resultado);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }

            string id = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();

            string resultado = _controller.Eliminar(id);

            if (resultado == "ok")
            {
                MessageBox.Show("Usuario eliminado");
                CargarUsuarios();
            }
            else
            {
                MessageBox.Show(resultado);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgvUsuarios.EndEdit(); 

            List<Usuario> lista = new List<Usuario>();

            foreach (DataGridViewRow fila in dgvUsuarios.Rows)
            {
                if (fila.IsNewRow) continue;

                lista.Add(new Usuario
                {
                    ID = fila.Cells[0].Value?.ToString(),
                    Nombre = fila.Cells[1].Value?.ToString(),
                    Telefono = fila.Cells[2].Value?.ToString(),
                    Correo = fila.Cells[3].Value?.ToString(),
                    Direccion = fila.Cells[4].Value?.ToString()
                });
            }

            _controller.GuardarLista(lista);

            MessageBox.Show("Cambios guardados correctamente");
            CargarUsuarios();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.ToLower();

            var lista = _controller.Listar();

            var filtrados = lista.FindAll(u =>
                u.ID.ToLower().Contains(texto) ||
                u.Nombre.ToLower().Contains(texto) ||
                u.Telefono.ToLower().Contains(texto) ||
                u.Correo.ToLower().Contains(texto) ||
                u.Direccion.ToLower().Contains(texto)
            );

            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = filtrados;
        }

        private void btnSesionesdeJuego_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.FormClosed += (s, d) => Application.Exit();
            this.Hide();
            home.Show();
        }
    }
}