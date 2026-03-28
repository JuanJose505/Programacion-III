using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazReproductorMusica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\JuanJ\Documents\GitHub\Programacion III\Segundo Corte\InterfazReproductorMusica\Let Down (Remastered).mp3";
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_tick(object sender, EventArgs e)
        {
            double duracion = axWindowsMediaPlayer1.currentMedia.duration;
            double posicion = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;

            if (duracion > 0)
            {
                progressBar1.Value = (int)((posicion / duracion) * 100);
            }
        }
    }
}
