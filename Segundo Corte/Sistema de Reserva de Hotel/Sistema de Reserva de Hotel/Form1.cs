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

            TimeSpan estancia = (dtmSalida.Value - dtmEntrada.Value);
            int dias = estancia.Days;

            int costobase = dias * 50;
            int costoextra = 0;
            int personas = (int)numPersonas.Value;
            if (personas > 1)
            {
                costoextra = (personas - 1) * 15 * dias;
            }

            int costoServicios = 0;
            string listaServicios = "";

            foreach (var item in clbServicios.CheckedItems)
            {
                costoServicios += 10 * dias;
                listaServicios += item.ToString() + ", ";
            }

            int total = costobase + costoextra + costoServicios;


            rtbResumen.Text =
                "=RESUMEN DE RESERVA=\n" +
                $"Cliente: {txtCliente.Text}\n" +
                $"Estancia: {dias} noches\n" +
                $"Personas: {personas}\n" +
                $"Servicios: {listaServicios}\n" +
                "------------------------------------\n" +
                $"TOTAL A PAGAR {total}";
        }
    }
}
