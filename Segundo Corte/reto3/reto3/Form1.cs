using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reto3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guardar();
            CargaryClasificar();
        }

        private void Guardar()
        {

            string nombrearchivo = "estudiante.csv";
            string nota = txtNota.Text.ToString();

            string linea = $"{txtNombre.Text};{nota}" + Environment.NewLine ;

            File.AppendAllText(nombrearchivo, linea);
        }

        private void CargaryClasificar()
        {
            lbAprobados.Items.Clear();
            lbReprobados.Items.Clear();
            string nombreArchivo = "estudiante.csv";
            


            string[] lineas = File.ReadAllLines(nombreArchivo);

            for (int i = 1; i < lineas.Length; i++)
            {
                string[] campos = lineas[i].Split(';');
                if (campos.Length >= 2)
                {
                    string nombre = campos[0].Trim();
                    int nota = int.Parse(campos[1]);

                    string Listado = $"{nombre};{nota}";
                    if (nota >= 3)
                    {
                        lbAprobados.Items.Add(Listado);
                    }
                    else
                    {
                        lbReprobados.Items.Add(Listado);
                    }
                    
                    
                }
            }



        }
    }
}
