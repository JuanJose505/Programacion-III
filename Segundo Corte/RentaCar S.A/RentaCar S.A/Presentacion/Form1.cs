using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentaCar_S.A.Datos;
using RentaCar_S.A.Entidades;
using RentaCar_S.A.Logica;

namespace RentaCar_S.A
{
    public partial class Form1 : Form
    {
        VehiculoService service = new VehiculoService();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Vehiculo v = new Vehiculo()
            {
                Id = int.Parse(txtID.Text),
                Placa = txtPlaca.Text,
                Marca = txtMarca.Text,
                Modelo = txtModelo.Text,
                Year = int.Parse(txtYear.Text),
                PrecioPorDia = double.Parse(txtPrecioxventa.Text)
            };

            service.AgregarVehiculo(v);

            MessageBox.Show("Vehiculo guardado");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = service.Listar();
        }
    }
}
