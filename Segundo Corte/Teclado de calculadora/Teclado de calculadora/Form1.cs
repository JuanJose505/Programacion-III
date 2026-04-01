using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teclado_de_calculadora
{
    public partial class form1 : Form
    {
        double num1 = 0;
        string operador = "";
        public form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pantalla.Text += "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (pantalla.Text.Length > 0)
            {
                num1 = Convert.ToDouble(pantalla.Text);
                operador = "/";
                pantalla.Text = "";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pantalla.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pantalla.Text += "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pantalla.Text += "3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pantalla.Text += "4";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pantalla.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pantalla.Text += "6";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pantalla.Text += "7";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pantalla.Text += "8";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pantalla.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (pantalla.Text.Length > 0)
            {
                pantalla.Text = pantalla.Text.Remove(pantalla.Text.Length - 1);
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(pantalla.Text);
            operador = "-";
            pantalla.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (pantalla.Text.Length > 0)
            {
                num1 = Convert.ToDouble(pantalla.Text);
                operador = "*";
                pantalla.Text = "";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {

            if (pantalla.Text.Length > 0)
            {
                num1 = Convert.ToDouble(pantalla.Text);
                operador = "+";
                pantalla.Text = "";
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (pantalla.Text.Length > 0)
            {
                double num2 = Convert.ToDouble(pantalla.Text);
                double resultado = 0;
                if (operador == "+")
                {
                    resultado = num1 + num2;
                    pantalla.Text = resultado.ToString();
                }
                else if (operador == "-")
                {
                    resultado = num1 - num2;
                    pantalla.Text = resultado.ToString();
                }
                else if (operador == "*")
                {
                    resultado = num1 * num2;
                    pantalla.Text = resultado.ToString();
                }
                else if (operador == "/")
                {
                    resultado = num1 / num2;
                    pantalla.Text = resultado.ToString();
                }


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
