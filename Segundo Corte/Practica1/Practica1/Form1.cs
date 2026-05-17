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

namespace Practica1
{
    public partial class Form1 : Form
    {
        string ruta = "usuarios.csv";
        public Form1()
        {
            InitializeComponent();
            Leer();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string texto = "";


            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.IsNewRow) continue;

                string id = fila.Cells[0].Value.ToString();
                string nombre = fila.Cells[1].Value.ToString();
                string telefono = fila.Cells[2].Value.ToString();

                if (id == "" || nombre == "" || telefono == "")
                {
                    MessageBox.Show("Campos emptys");
                }

                texto += $"{id};{nombre};{telefono}{Environment.NewLine}";

                
                
                
            }
            File.WriteAllText(ruta, texto);
            MessageBox.Show("Guardado correctamente");


        }


        private void Leer()
        {
            if (!File.Exists(ruta))
            {
                return; 
            }
            
            dataGridView1.Rows.Clear();
            var lineas = File.ReadAllLines(ruta);

            foreach (string linea in lineas)
            {
                var campo = linea.Split(';');
                dataGridView1.Rows.Add(campo);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un valor a eliminar");
                return;
            }
            var lineas = File.ReadAllLines(ruta);
            string texto = "";
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var nuevaslineas = "";
            foreach (string linea in lineas)
            {
                var campos = linea.Split(';');

                if (campos[0] != id)
                {
                    string idd = campos[0];
                    string nombre = campos[1];
                    string telefono = campos[2];
                    texto = $"{idd};{nombre};{telefono}{Environment.NewLine}";

                }
                else
                {

                }
                


            }
            File.WriteAllText(ruta, texto);
            MessageBox.Show("Borrado con exito");
            Leer();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {


            var lineas = File.ReadAllLines(ruta);

            string texto = "";
            string id = "";

            var fila = dataGridView1.SelectedRows[0];

            if (fila.Cells[0].Value.ToString() != null)
            {
                id = fila.Cells[0].Value.ToString();

            }


            string nombre = fila.Cells[1].Value.ToString();
            string telefono = fila.Cells[2].Value.ToString();

            foreach (string linea in lineas)
            {
                var campo = linea.Split(';');

                if (campo[0] == id)
                {
                    texto = $"{id};{nombre};{telefono};{Environment.NewLine}";
                }
                else
                {
                    texto += linea + Environment.NewLine;
                }
            }
            File.WriteAllText(ruta, texto);
            MessageBox.Show("actualizado melo");
            Leer();
        }
    }
}
