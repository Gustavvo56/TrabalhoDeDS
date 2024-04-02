using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeDS1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double lado1, lado2, lado3;
            string valor;

            valor = "È um triângulo";

            lado1 = double.Parse(textBox1.Text);
            lado2 = double.Parse(textBox2.Text);
            lado3 = double.Parse(textBox3.Text);


            if (lado1 != lado2 && lado2 != lado3 && lado1 != lado3)
            {
                valor = "È um triângulo escaleno";

            }
            else if (lado1 == lado2 & lado3 != lado1 && lado3 != lado2 || lado2 == lado3
                      && lado1 != lado2 && lado1 != lado3 || lado1 == lado3 && lado2 != lado1
                       && lado2 != lado3)
            {
                valor = "È um triângulo isósceles";

            }
            else if (lado1 == lado2 && lado1 == lado3 && lado2 == lado3)
            {
                valor = "È um triângulo equilátero";

            }
            else if (lado1 <= 0 || lado2 <= 0 || lado3 <= 0 ||
                    lado1 + lado2 <= lado3 || lado1 + lado3 <= lado2 ||
                    lado3 + lado2 <= lado1)
            {
                valor = "Não é um triângulo";
            }

            textBox4.Text = valor;
        }
    }
}

