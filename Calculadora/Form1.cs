using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        decimal valor1 = 0, valor2 = 0, valor3 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                textBox.Text = textBox.Text + "0";
            }
            else
            {
                textBox.Text += "0.";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox.Text += "1";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox.Text += "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox.Text += "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox.Text += "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox.Text += "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox.Text += "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text += "9";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox.Text += ",";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            


            if (textBox.Text != "")
            {
                

                if (operacao == "soma")
                {
                    valor2 = decimal.Parse(textBox.Text, CultureInfo.InvariantCulture);
                    valor3 = valor1 + valor2;
                    textBox.Text = Convert.ToString(valor3);
                    valor1 = 0; valor2 = 0;
                }

                else if (operacao == "sub")
                {
                    valor2 = decimal.Parse(textBox.Text, CultureInfo.InvariantCulture);
                    valor3 = valor1 - valor2;
                    textBox.Text = Convert.ToString(valor3);
                    valor1 = 0; valor2 = 0;
                }

                else if (operacao == "mult")
                {
                    valor2 = decimal.Parse(textBox.Text, CultureInfo.InvariantCulture);
                    valor3 = valor1 * valor2;
                    textBox.Text = Convert.ToString(valor3);
                    valor1 = 0; valor2 = 0;
                }

                else if (operacao == "div")
                {
                    valor2 = decimal.Parse(textBox.Text, CultureInfo.InvariantCulture);
                    valor3 = valor1 / valor2;
                    textBox.Text = Convert.ToString(valor3);
                    valor1 = 0; valor2 = 0;
                }

                else if (operacao == "sqr")
                {

                    valor3 = (decimal)Math.Sqrt((double)valor1);
                    textBox.Text = Convert.ToString(valor3);
                    valor1 = 0;
                    lblTxtBox.Text = "";

                }

                else if (operacao == "porc")
                {
                    valor2 = decimal.Parse(textBox.Text, CultureInfo.InvariantCulture);
                    valor3 = (valor1*valor2)/100;
                    textBox.Text = Convert.ToString(valor3);
                    valor1 = 0; valor2 = 0;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                valor1 = decimal.Parse(textBox.Text, CultureInfo.InvariantCulture);
                textBox.Text = "";
                operacao = "sub";
                lblTxtBox.Text = "-";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                valor1 = decimal.Parse(textBox.Text, CultureInfo.InvariantCulture);
                textBox.Text = "";
                operacao = "mult";
                lblTxtBox.Text = "x";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                valor1 = decimal.Parse(textBox.Text, CultureInfo.InvariantCulture);
                textBox.Text = "";
                operacao = "div";
                lblTxtBox.Text = "/";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                valor1 = decimal.Parse(textBox.Text, CultureInfo.InvariantCulture);

                operacao = "sqr";
                lblTxtBox.Text = "√";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox.Text != "")
            {
                valor1 = decimal.Parse(textBox.Text, CultureInfo.InvariantCulture);
                textBox.Text = "";
                operacao = "porc";
                lblTxtBox.Text = "%";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            valor1 = 0; valor2 = 0;
            lblTxtBox.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                valor1 = decimal.Parse(textBox.Text, CultureInfo.InvariantCulture);
                textBox.Text = "";
                operacao = "soma";
                lblTxtBox.Text = "+";
            }
        }
    }
}
