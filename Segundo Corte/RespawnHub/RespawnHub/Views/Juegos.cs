using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RespawnHub.Controllers;
using RespawnHub.Models;
using System.Diagnostics;

namespace RespawnHub.Views
{
    public partial class Juegos : Form
    {
        private JuegoController juegoController = new JuegoController();

        private string rutaFoto="";

        private string rutaJuego = "";

        public Juegos()
        {
            InitializeComponent();
            ListarJuegos();
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        { }
        private void LimpiarCampos()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtDesarrollador.Clear();
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
            string rutaEjecutableSeleccionada = rutaJuego;

            string respuesta = juegoController.RegistrarJuego(id, nombre, descripcion, desarrollador, rutaimagenseleccionada, rutaEjecutableSeleccionada);

            ListarJuegos(); 


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

            flowLayoutPanel1.Controls.Clear();
            List<Juego> juegos = juegoController.ObtenerJuegos();
            foreach (var juego in juegos)
            {
                Button btnJuego = new Button();
                btnJuego.Size = new Size(150, 225);
                btnJuego.Margin = new Padding(10);
                btnJuego.Cursor = Cursors.Hand;

                btnJuego.FlatStyle = FlatStyle.Flat;
                btnJuego.FlatAppearance.BorderSize = 0;
                btnJuego.BackColor = Color.FromArgb(40, 40, 40);
                btnJuego.ForeColor = Color.White;

                Button btnBorrar = new Button();
                btnBorrar.Text = "X";
                btnBorrar.Size = new Size(30, 30);
                btnBorrar.Location = new Point(118, 5);
                btnBorrar.BackColor = Color.FromArgb(40, 40, 40);
                btnBorrar.ForeColor = Color.White;
                btnBorrar.Click += (s, ev) =>
                {
                    var confirmar = MessageBox.Show("Desea borrar el juego?", "Confirmar" ,MessageBoxButtons.YesNo);
                    if (confirmar == DialogResult.Yes)
                    {
                        juegoController.Eliminar(juego.ID);
                        ListarJuegos();
                    }
                    
                };

                string rutaimagen = Path.Combine(Application.StartupPath, "images", juego.RutaImagenSeleccionada);

                if (File.Exists(rutaimagen))
                {
                    btnJuego.BackgroundImage = Image.FromFile(rutaimagen);
                    btnJuego.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else
                {
                    btnJuego.Text = (juego.Nombre);
                    btnJuego.Font = new Font ("Segoe UI",10,FontStyle.Bold  );
                }


                btnJuego.Click += (s, ev) =>
                {
                    if (juego.RutaEjecutableSeleccionada == "")
                    {
                        MessageBox.Show("Este juego no cuenta con una ruta registrada");
                    }
                    else
                    {
                        Process proceso = new Process();
                        proceso.StartInfo.FileName = juego.RutaEjecutableSeleccionada;
                        proceso.StartInfo.WorkingDirectory = Path.GetDirectoryName(juego.RutaEjecutableSeleccionada);
                        proceso.Start();
                    }
                };

                flowLayoutPanel1.Controls.Add(btnJuego);
                flowLayoutPanel1.Controls.Add(btnBorrar);
            }
        }

        private void btnGameDir_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscador = new OpenFileDialog();
            buscador.Filter = "Archivo ejecutable |*.exe";

            if (buscador.ShowDialog() == DialogResult.OK)
            {
                rutaJuego = buscador.FileName;
            }
        }

        private void btnSesionesdeJuego_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.FormClosed += (s, d) => Application.Exit();
            this.Hide();
            home.Show();
        }

        private void BtnLimpiarJuego_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
