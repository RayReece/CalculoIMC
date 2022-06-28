using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1 = 0;
            double n2 = 0;
            double resultado = 0;
            if (txtPeso.Text != "" && txtAltura.Text != "")
            {
                n1 = double.Parse(txtPeso.Text);
                n2 = double.Parse(txtAltura.Text);

            }
            resultado = n1 / Math.Pow(n2,2);

            if (resultado <= 18.5)
            {
                lblValor.Text = resultado.ToString();
                lblStatus.Text = "abaixo do peso";

            }
            else if (resultado > 18.5 && resultado <= 24.9)
            {
                lblValor.Text = resultado.ToString();
                lblStatus.Text = "peso ideal";
            }
            else if (resultado > 25 && resultado <= 29.9) 
            {
                lblValor.Text = resultado.ToString();
                lblStatus.Text = "levemente acima do peso";
            }
            else if (resultado > 30 && resultado <= 34.9)
            {
                lblValor.Text = resultado.ToString();
                lblStatus.Text = "obesidade primeiro grau";
            }
            else if (resultado < 35 && resultado <= 39.9)
            {
                lblValor.Text = resultado.ToString();
                lblStatus.Text = "obesidade segundo grau (severa)";
            }
            else
            {
                lblValor.Text = resultado.ToString();
                lblStatus.Text = "obesidade terceiro grau(mórbida)";
            }


        }
    }
}
