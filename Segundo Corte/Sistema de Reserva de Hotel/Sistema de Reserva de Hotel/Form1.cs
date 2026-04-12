using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Reserva_de_Hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularReserva_Click(object sender, EventArgs e)
        {
            bool validateentrada = false;
            bool validatesalida = false;

            if (dtmEntrada.Value>=DateTime.Today)
            {
                validateentrada = true;
            }

            if (dtmSalida.Value >= dtmEntrada.Value.AddDays(1))
            {
                validatesalida = true;
            }

            TimeSpan estancia = (dtmEntrada.Value - dtmSalida.Value);
            int dias = estancia.Days;

        }
    }
}
