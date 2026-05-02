using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RespawnHub.Forms;
using RespawnHub.Views;

namespace RespawnHub
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.FormClosed += (s, d) => Application.Exit();
            usuario.Show();
            this.Hide();
        }

        private void btnJuegos_Click(object sender, EventArgs e)
        {
            Juegos juegos = new Juegos();
            juegos.FormClosed += (s, d) => Application.Exit();
            juegos.Show();
            this.Hide();
        }

        private void btnSesionesdeJuego_Click(object sender, EventArgs e)
        {
            Sesiones sesiones = new Sesiones();
            sesiones.FormClosed += (s, d) => Application.Exit();
            sesiones.Show();
            this.Hide();
        }

        private void btnBiblioteca_Click(object sender, EventArgs e)
        {
            Estadisticas estadisticas = new Estadisticas();
            estadisticas.FormClosed += (s, d) => Application.Exit();
            estadisticas.Show();
            this.Hide();
        }
    }
}
