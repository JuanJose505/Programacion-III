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

namespace Control_de_Ventas_Diarias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ruta = "ventas.csv";
            string linea = $"{txtID.Text};{numMonto.Value}";
            File.AppendAllText(ruta, linea + Environment.NewLine);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbHistorial.Items.Clear();
            string ruta = "ventas.csv";
            string[] lineas = File.ReadAllLines(ruta);
            decimal MontoTotal = 0;
            for (int i = 0; i < lineas.Length; i++)
            {
                string[] campos = lineas[i].Split(';');
                if (campos.Length >= 2)
                {
                    string ID = campos[0];
                    decimal Monto = decimal.Parse(campos[1]);
                    MontoTotal = MontoTotal + Monto;

                    string linea = $"{ID} - {Monto}";
                    lbHistorial.Items.Add(linea);                    
                    
                }
                lblTotal.Visible = true;
                lblTotal.Text = $"TOTAL: {MontoTotal}";

            }
        }
    }
}
