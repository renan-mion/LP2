using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulo
{
    public partial class Form1 : Form
    {
        double ladoA;
        double ladoB;
        double ladoC;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLadoA.Clear();
            txtLadoB.Clear();
            txtLadoC.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        { 
            if (Double.TryParse(txtLadoA.Text, out ladoA) && Double.TryParse(txtLadoB.Text, out ladoB) && Double.TryParse(txtLadoC.Text, out ladoC) && (ladoA > 0 && ladoB > 0 && ladoC > 0))
            {
                bool validarA = ladoA < (ladoB + ladoC) && ladoA > Math.Abs(ladoB - ladoC);
                bool validarB = ladoB < (ladoA + ladoC) && ladoB > Math.Abs(ladoA - ladoC);
                bool validarC = ladoA < (ladoA + ladoB) && ladoA > Math.Abs(ladoA - ladoB);
                if (!(validarA && validarB && validarC))
                {
                    MessageBox.Show("Valores não formam triângulo");
                }
                else
                {
                    if (ladoA == ladoB && ladoB == ladoC)
                        MessageBox.Show("Triângulo Equilátero");
                    else if (ladoA != ladoB && ladoB != ladoC && ladoA != ladoC)
                        MessageBox.Show("Triângulo Escaleno");
                    else
                        MessageBox.Show("Triângulo Isósceles");
                }
            }
            else
            {
                MessageBox.Show("Digite um número válido");
            }
        }
    }
}
