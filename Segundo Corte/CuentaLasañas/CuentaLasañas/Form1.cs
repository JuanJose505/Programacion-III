using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CuentaLasañas
{
    public partial class Form1 : Form
    {
       
        ClienteController controller = new ClienteController();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = controller.Listar();
            ActualizarProgressBar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente()
            {
                Nombre = txtNombre.Text,
                Diadeentrega = cmbDiaentrega.SelectedItem.ToString(),
                Horadeentrega = cmbHoraentrega.SelectedItem.ToString(),
                Cantidadvendida = int.Parse(MtxtCantidad.Text)
            };

            string validar = controller.ValidarCliente(cliente);
            if (validar == "Cliente validado con exito")
            {
                
                controller.AgregarCliente(cliente);


                dataGridView1.DataSource = null;
                dataGridView1.DataSource = controller.Listar();
                MessageBox.Show("Cliente ingresado a la base de datos");
                ActualizarProgressBar();
            }
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
        }
        private void ActualizarProgressBar()
        {
            var lista = controller.Listar();

            if (lista == null || lista.Count == 0)
                return;

            int totalVentas = lista.Sum(c => c.Cantidadvendida);

            int meta = 40;

            lblBarra.Text = $"Progreso: {totalVentas} / {meta} lasañas";

            progressBar1.Maximum = meta;

            
            if (totalVentas <= meta)
                progressBar1.Value = totalVentas;
            else
                progressBar1.Value = meta;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();

            List<Cliente> lista = new List<Cliente>();

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.IsNewRow) continue;

                lista.Add(new Cliente
                {
                    Nombre = fila.Cells[0].Value?.ToString(),
                    Diadeentrega = fila.Cells[1].Value?.ToString(),
                    Horadeentrega = fila.Cells[2].Value?.ToString(),
                    Cantidadvendida = int.Parse(fila.Cells[3].Value?.ToString() ?? "0")
                });
            }

            controller.GuardarLista(lista);

            MessageBox.Show("Cambios guardados correctamente");

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = controller.Listar();
            ActualizarProgressBar();
        }
    }
}
