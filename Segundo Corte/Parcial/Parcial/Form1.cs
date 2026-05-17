using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial
{
    public partial class Form1 : Form
    {
        string ruta = "productos.csv";
        public Form1()
        {
            InitializeComponent();
            Leer();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            bool validate = false;
            bool validateprecio = false;
            bool validatecategoria = false;

            if (txtPrecio.Text == "")
            {
                MessageBox.Show("Ingrese un precio para continuar");
                return;
            }
            else
            {
                validateprecio = true;
            }

            if (cmbCategoria.SelectedItem == null)
            {
                MessageBox.Show("Ingrese una categoria para continuar");
                return;
            }
            else
            {
                validatecategoria = true;
            }

            if (validatecategoria && validateprecio)
            {
                string id = txtID.Text;
                string nombre = txtNombre.Text;
                string categoria = cmbCategoria.SelectedItem.ToString();
                string marca = txtMarca.Text;
                string f_ingreso = dateTimePicker1.Value.ToString();
                string precio = txtPrecio.Text;
                string stock = txtStock.Text;
                string proveedor = txtProveedor.Text;

                var linea = $"{id};{nombre};{categoria};{marca};{precio};{stock};{proveedor};{f_ingreso}{Environment.NewLine}";

                File.WriteAllText(ruta, linea);
                MessageBox.Show("Ingresado con exito");
                Leer();
            }


        }

        private void Leer()
        {
            if (!File.Exists(ruta))
            {
                File.Create(ruta);
            }

            var lineas = File.ReadLines(ruta);
            foreach (string linea in lineas)
            {
                var campo = linea.Split(';');
                dataGridView1.Rows.Add(campo);
                
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
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
            string categoria = fila.Cells[2].Value.ToString();
            string marca = fila.Cells[3].Value.ToString();
            string precio = fila.Cells[4].Value.ToString();
            string stock = fila.Cells[5].Value.ToString();
            string proveedor = fila.Cells[6].Value.ToString();
            string f_ingreso = fila.Cells[7].Value.ToString();

            foreach (string linea in lineas)
            {
                var campo = linea.Split(';');

                if (campo[0] == id)
                {
                    texto = $"{id};{nombre};{categoria};{marca};{precio};{stock};{proveedor};{f_ingreso};{Environment.NewLine}";
                }
            }

            File.WriteAllText(ruta,texto);
            MessageBox.Show("Actualizado con exito");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtMarca.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtProveedor.Clear();
            txtStock.Clear();
            cmbCategoria.Items.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para eliminar");
                return;
            }

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string nuevaslineas = "";

            var lineas = File.ReadAllLines(ruta);
            foreach (string linea in lineas)
            {
                var campo = linea.Split(';');
                if (campo[0] != id)
                {
                    string idd = campo[0];
                    string nombre = campo[1];
                    string categoria = campo[2];
                    string marca = campo[3];
                    string precio = campo[4];
                    string stock = campo[5];
                    string proveedor = campo[6];
                    string f_ingreso = campo[7];

                    nuevaslineas = $"{idd};{nombre};{categoria};{marca};{precio};{stock};{proveedor};{f_ingreso};{Environment.NewLine}";
                }

                File.WriteAllText(ruta, nuevaslineas);
                MessageBox.Show("Borrado con exito");
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Leer();
        }
    }
}
