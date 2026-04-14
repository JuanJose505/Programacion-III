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

namespace Gestión_de_Inventario__CSV_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ruta = "productos.csv";
            string linea = $"{txtNombre.Text};{txtCodigo.Text};{numCosto.Value};{numCantidad.Value}";
            File.AppendAllText(ruta, linea + Environment.NewLine);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbProductos.Items.Clear();
            string ruta = "productos.csv";
            string[] lines = File.ReadAllLines(ruta);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] campos = lines[i].Split(';');

                if (campos.Length >= 4)
                {
                    string nombre = campos[0];
                    int codigo = int.Parse(campos[1]);
                    int costo = int.Parse(campos[2]);
                    int cantidad = int.Parse(campos[3]);
                    string linea = $"{nombre} - {codigo} - {costo} - {cantidad}";
                    lbProductos.Items.Add(linea);
                }


            }
        
        
        }
    }
}
