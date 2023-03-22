using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        double altura, peso, IMC;
        string classe;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtAltura.Text, out altura)) && (double.TryParse(txtPeso.Text, out peso)) && (altura > 0) && (peso > 0))
            {
                IMC = peso / Math.Pow(altura, 2);
                IMC = Math.Round(IMC, 1);
                txtIMC.Text = IMC.ToString("N1");
                if (IMC < 18.5)
               
                    classe = "Magreza, grau de obesidade: 0";

                else if (IMC < 24.9)

                    classe = "Normal, grau de obesidade: 0";
                else if (IMC < 29.9)

                    classe = "Sobrepeso, grau de obesidade: 1";
                else if (IMC < 39.9)

                    classe = "Obesidade, grau de obesidade: 2";
                else

                    classe = "obesidade grave, grau de obesidade: 3";
                txtClasse.Text = classe;


            }
            else MessageBox.Show("Insira um numero valido");
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtPeso.Clear();
            txtIMC.Clear();
            txtClasse.Clear();
        }
    }
}
