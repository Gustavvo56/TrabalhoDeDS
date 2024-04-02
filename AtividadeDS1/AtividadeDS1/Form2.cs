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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor1, IRS, SS, somadesco, salarioatual;
            string valor;

            valor = textBox1.Text;

            valor1 = double.Parse(valor);


            IRS = (valor1 * 15) / 100;
            SS = (valor1 * 12) / 100;
            somadesco = IRS + SS;
            salarioatual = valor1 - somadesco;


            textBox2.Text = somadesco.ToString();
            textBox3.Text = salarioatual.ToString();
        }
    }
}
