using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RespawnHub.Controllers;
using RespawnHub.Models;

namespace RespawnHub.Views
{
    public partial class Estadisticas : Form
    {
        SesionController _controllersesion = new SesionController();

        public Estadisticas()
        {
            InitializeComponent();
            this.Load += Estadisticas_Load;
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            CargarTarjetas();
            CargarTabla();
        }

        private void CargarTarjetas()
        {
            lblTotalHoras.Text = _controllersesion.TotalHoras().ToString();
            lblSesiones.Text = _controllersesion.TotalSesiones().ToString();
            lblPromedio.Text = _controllersesion.PromedioPorSesion().ToString("F1");
            lblMasJugado.Text = _controllersesion.JuegoMasJugado();
            label5.Text = _controllersesion.HorasJuegoMasJugado().ToString() + " horas";
        }

        private void CargarTabla()
        {
            var sesiones = _controllersesion.Listar();

            var porJuego = sesiones
                .GroupBy(s => s.NombreJuego)
                .Select(g => new
                {
                    Juego = g.Key,
                    Sesiones = g.Count(),
                    Horas = g.Sum(s => s.Horas)
                })
                .OrderByDescending(x => x.Horas)
                .ToList();

            dgvJuegos.DataSource = porJuego;

            dgvJuegos.SelectionChanged += (s, ev) => ActualizarProgressBar();
            dgvJuegos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ActualizarProgressBar()
        {
            if (dgvJuegos == null || dgvJuegos.CurrentRow == null || dgvJuegos.IsDisposed) return;

            int horasJuego = Convert.ToInt32(dgvJuegos.CurrentRow.Cells["Horas"].Value);
            int totalHoras = _controllersesion.TotalHoras();
            string nombreJuego = dgvJuegos.CurrentRow.Cells["Juego"].Value.ToString();

            lblJuegoBarra.Text = $"{nombreJuego} — {horasJuego} de {totalHoras} horas totales";

            if (totalHoras > 0)
            {
                progressBar1.Maximum = totalHoras;
                progressBar1.Value = horasJuego;
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