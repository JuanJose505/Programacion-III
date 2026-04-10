using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformacionPersonal2
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool validate1 = true;
            bool validate2 = true;
            bool validate3 = true;
            bool validate4 = true;
            bool validatef = false;

            if (txtCorreo.Text == "")
            {
                lblCorreo.Visible = true;
                lblCorreo.Text = "El campo correo es obligatorio";
                validate1 = false;

            }
            else
            {
                if (txtCorreo.Text.Contains("@") && txtCorreo.Text.Contains(".com"))
                {
                    lblCorreo.Visible = false;
                    validate1 = true;
                }
            }

            if (txtCorreo.Text != txtValidarCorreo.Text)
            {
                lblValidarCorreo.Visible = true;
                lblValidarCorreo.Text = "Los correos no concuerda, ingreselo de nuevo";
                validate2 = false;
            }
            else
            {
                lblValidarCorreo.Visible = false;
                validate2 = true;
            }


            if (!rbMasculino.Checked && !rbFemenino.Checked)
            {
                lblGenero.Visible = true;
                lblGenero.Text = "Por favor marque al menos un genero";
                validate3 = false;

            }
            else
            {
                lblGenero.Visible = false;
                validate3 = true;
            }

            if (txtNombres.Text == "")
            {
                lblNombres.Visible = true;
                lblNombres.Text = "Ingrese un nombre valido";
                validate4 = false;
            }
            else
            {
                lblNombres.Visible = false;
                validate4 = true;
            }


            if (validate1 && validate2 && validate3 && validate4 == true)
            {
                validatef = true;
            }


            if (validatef == true)
            {
                lblRegistrar.Visible = true;
                lblRegistrar.Text = "Usuario validado con exito!";
               
            }
            else
            {
                lblRegistrar.Visible = false;

            }


            if (validatef == true)
            {

                string nombresitos = txtNombres.Text;
                string correito = txtCorreo.Text;

                string generito = ""; 
                if (rbMasculino.Checked)
                {
                    generito = "Masculino";
                    
                }
                else if (rbFemenino.Checked)
                {
                    generito = "Femenino";
                    
                }

                string linea = nombresitos + ";" + correito + ";" + generito;


                File.AppendAllText("datos.csv", linea + Environment.NewLine);


            }
        }



        private void lblValidarCorreo_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
