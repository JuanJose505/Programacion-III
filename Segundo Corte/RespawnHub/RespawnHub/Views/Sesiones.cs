using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RespawnHub.Controllers;
using RespawnHub.Models;

namespace RespawnHub.Views
{
    public partial class Sesiones : Form
    {

        JuegoController _controllerjuego = new JuegoController();
        SesionController _controllersesion = new SesionController();
        UsuarioController _controllerusuario = new UsuarioController();

        public Sesiones()
        {
            InitializeComponent();
            this.Load += Sesiones_Load;
        }

        private void Sesiones_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToString("dd/mm/yyyy");
            txtFecha.Enabled = false;
            CargarComboJuegos();
            CargarComboUsuarios();
            CargarComboModos();
            CargarSesiones();
        }

        private void CargarComboJuegos()
        {
            cmbJuego.DataSource = null;
            cmbJuego.DataSource = _controllerjuego.ObtenerJuegos();
            cmbJuego.DisplayMember = "Nombre";
            cmbJuego.ValueMember = "ID";

        }

        private void CargarComboUsuarios()
        {
            cmbUsuario.DataSource = null;
            cmbUsuario.DataSource = _controllerusuario.Listar();
            cmbUsuario.DisplayMember = "Nombre";
            cmbUsuario.ValueMember = "ID";
            
        }

        private void CargarComboModos()
        {
            cmbModo.DataSource = null;
            cmbModo.Items.Add("Historia");
            cmbModo.Items.Add("Multijugador");
            cmbModo.Items.Add("Cooperativo");
            cmbModo.Items.Add("Libre");
            cmbModo.Items.Add("Competitivo");
            cmbModo.SelectedIndex = 0;

        }

        private void CargarSesiones()
        {
            dgvSesiones.DataSource = null;
            dgvSesiones.DataSource = _controllersesion.Listar();
        }  

        private void LimpiarCampos()
        {
            txtID.Clear();
            txtHoras.Clear();
            txtNotas.Clear();
            cmbJuego.SelectedIndex = 0;
            cmbModo.SelectedIndex = 0;
            cmbUsuario.SelectedIndex = 0;
        }

        private void btnSesionesdeJuego_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.FormClosed += (s, d) => Application.Exit();
            this.Hide();
            home.Show();
        }

        private void bntLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cmbJuego.SelectedIndex == null || cmbUsuario.SelectedIndex  == null)
            {
                MessageBox.Show("Selecciona un juego y un usuario");
                return;
            }
            
            if (!int.TryParse(txtHoras.Text, out int horas))
            {
                MessageBox.Show("Las horas deben ser un numero");
                return;
            }

            Juego juegoseleccionado = (Juego)cmbJuego.SelectedItem;
            Usuario usuarioseleccionado = (Usuario)cmbUsuario.SelectedItem;


            string resultado = _controllersesion.Crear(

                txtID.Text,
                txtFecha.Text,
                juegoseleccionado.ID.ToString(),
                juegoseleccionado.Nombre,
                cmbModo.SelectedItem.ToString(),
                txtNotas.Text,
                horas,
                usuarioseleccionado.ID,
                usuarioseleccionado.Nombre

                );

            if (resultado == "ok")
            {
                MessageBox.Show("Sesion registrada con exito");
                CargarSesiones();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show(resultado);
            }
        }

        private void btnEliminarSeleccionada_Click(object sender, EventArgs e)
        {
            if (dgvSesiones.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una sesion");
                return;
            }

            string id = dgvSesiones.CurrentRow.Cells[0].Value.ToString();
            string resultado = _controllersesion.Eliminar(id);

            if (resultado == "ok")
            {
                MessageBox.Show("Sesion eliminada con exito");
                CargarSesiones();
            }
            else
            {
                MessageBox.Show(resultado);
            }
        }
    }
}
