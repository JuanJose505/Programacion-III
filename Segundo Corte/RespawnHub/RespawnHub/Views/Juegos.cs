using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RespawnHub.Controllers;

namespace RespawnHub.Views
{
    public partial class Juegos : Form
    {
        private JuegoController juegoController = new JuegoController();

        private string rutaFoto="";
        public Juegos()
        {
            InitializeComponent();
            
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            

            

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscador = new OpenFileDialog();
            buscador.Filter = "Archivos de imagen | *.jpg; *.jpeg;*.png;";

            if (buscador.ShowDialog() == DialogResult.OK)
            {
                rutaFoto = buscador.FileName;
            }
            
        }

        private void btnRegistrarJuego_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            string desarrollador = txtDesarrollador.Text;
            string rutaimagenseleccionada = rutaFoto;
            string rutaEjecutableSeleccionada = "";

            string respuesta = juegoController.RegistrarJuego(id, nombre, descripcion, desarrollador, rutaimagenseleccionada, rutaEjecutableSeleccionada);

            if(respuesta != "ok")
            {
                MessageBox.Show(respuesta);
            } else
            {
                MessageBox.Show("Juego creado con exito!!");
            }

        }

        private void ListarJuegos()
        {
            //Button btnJuego = new Button();
            //btnJuego.Size = new Size(150, 225);
            //btnJuego.Margin = new Padding(10);
            //btnJuego.Cursor = Cursors.Hand;

            //btnJuego.FlatStyle = FlatStyle.Flat;
            //btnJuego.FlatAppearance.BorderSize = 0;
            //btnJuego.BackColor = Color.FromArgb(40, 40, 40);
            //btnJuego.ForeColor = Color.White;


            //if (!String.IsNullOrEmpty(rutaImagenSeleccionada))
            //{
            //    btnJuego.BackgroundImage = Image.FromFile(rutaImagenSeleccionada);
            //    btnJuego.BackgroundImageLayout = ImageLayout.Stretch;
            //}
            //else
            //{
            //    btnJuego.Text = txtNombre.Text;
            //    btnJuego.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            //}

            //btnJuego.Click += (s, ev) =>
            //{
            //    MessageBox.Show($"{txtNombre.Text}\n{txtDesarrollador.Text}");
            //};

            //ToolTip tt = new ToolTip();
            //tt.SetToolTip(btnJuego, txtNombre.Text);

            //flowLayoutPanel1.Controls.Add(btnJuego);
        }

        private void btnGameDir_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscador = new OpenFileDialog();
            buscador.Filter = "Archivo ejecutable |*.exe";

            if (buscador.ShowDialog() == DialogResult.OK)
            {
                //rutaJuegoSeleccionado = buscador.FileName;
            }
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
