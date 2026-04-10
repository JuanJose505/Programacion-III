using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Registro_de_Empleados
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

        private void button1_Click(object sender, EventArgs e)
        {
            bool validate_name = false;
            bool validate_apellidos = false;
            bool validate_email = false;
            bool validate_id = false;
            bool validation = false;


            if (txtNombres.Text == "")
            {
                lblErrorNombre.Visible = true;
                lblErrorNombre.Text = "Ingrese un nombre!";
            }
            else
            {
                lblErrorNombre.Visible = false;
                validate_name = true;
            }

            if (TxtApellidos.Text == "")
            {
                lblErrorApellidos.Visible = true;
                lblErrorApellidos.Text = "Ingrese un apellido!";
            }
            else
            {
                lblErrorApellidos.Visible = false;
                validate_apellidos = true;
            }

            if (txtEmail.Text == "")
            {
                lblErrorEmail.Visible = true;
                lblErrorEmail.Text = "Ingrese un Email!";
            }
            else
            {
                if (txtEmail.Text.Contains("@") && txtEmail.Text.Contains(".com"))
                {
                    lblErrorEmail.Visible = false;
                    validate_email = true;
                }
            }

            if (txtIdentificacion.Text == "")
            {
                lblErrorIdentificacion.Visible = true;
                lblErrorIdentificacion.Text = "ID invalido (10 digitos)!";
            }
            else
            {
                
                if (txtIdentificacion.Text.Length == 10)
                {
                    lblErrorIdentificacion.Visible = false;
                    validate_id = true;
                }
                else
                {
                    lblErrorIdentificacion.Visible = true;
                    lblErrorIdentificacion.Text = "ID invalido (10 digitos)!";
                }
            }

            if (validate_name == true && validate_apellidos == true && validate_email == true && validate_id == true)
            {
                validation = true;
            }

            if (validation == true)
            {
                decimal sueldo_base = numSueldoBase.Value;
                decimal sueldo_neto = (sueldo_base - (sueldo_base * 0.10m));
                lblSueldoNeto.Visible = true;
                lblSueldoNeto.Text = "Sueldo Neto : " + sueldo_neto.ToString();
            }

            if (validation == true)
            {
                lblRegistro.Visible = true;
                lblRegistro.Text = "Usuario registrado";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNombres.Clear();
            TxtApellidos.Clear();
            txtIdentificacion.Clear();
            txtEmail.Clear();
            cmbDepartamento.SelectedIndex = -1;
            numSueldoBase.Value = numSueldoBase.Minimum;
        }
    }
}
