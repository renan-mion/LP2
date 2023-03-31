using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSalario
{
    public partial class Form1 : Form
    {
        double salarioBruto = 0;
        double salarioLiquido = 0;
        double descontoINSS = 0;
        double descontoIRPF = 0;
        double salarioFamilia = 0;
        int numfilhos = 0;
        string porcentagemINSS = "";
        string porcentagemIRPF = "";
        string nome = "";
        string abreviatura = "";
        string estCivil = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnVerifDesconto_Click(object sender, EventArgs e)
        {
            // String lblDados
            if (txtNome.Text == "")
            {
                MessageBox.Show("Caixa de nome vazia");
                txtNome.Focus();
            }
            else if (!rbtnFem.Checked && !rbtnMasc.Checked)
                MessageBox.Show("Caixa de sexo desmarcada");
            else
            { 
                nome = txtNome.Text;
                if (rbtnFem.Checked)
                abreviatura = " da Sra ";
                else if (rbtnMasc.Checked)
                abreviatura = " do Sr ";

                if (ckbxCasado.Checked)
                    estCivil = " Casado(a) ";
                else
                    estCivil = " Solteiro(a) ";

                numfilhos = Convert.ToInt32(nudNumFilhos.Value);

                if (!Double.TryParse(mskbxSalBruto.Text, out salarioBruto))
                    MessageBox.Show("Salário Inválido");
                else if (salarioBruto == 0)
                    MessageBox.Show("Salário deve ser maior que 0");
                else
                {

                    lblDados.Text = "Os descontos do salário" + abreviatura + nome + " que é" + estCivil + "e que tem " + numfilhos + " filho(s)";
                    
                    // Cálculo INSS
                    if (salarioBruto <= 800.47)
                    {
                        porcentagemINSS = "7.5%";
                        descontoINSS = salarioBruto * 0.0765;
                    }
                    else if (salarioBruto <= 1050)
                    {
                        porcentagemINSS = "8.65%";
                        descontoINSS = salarioBruto * 0.0865;
                    }
                    else if (salarioBruto <= 1400.77)
                    {
                        porcentagemINSS = "9.00%";
                        descontoINSS = salarioBruto * 0.09;
                    }
                    else if (salarioBruto <= 2801.56)
                    {
                        porcentagemINSS = "11.00%";
                        descontoINSS = salarioBruto * 0.11;
                    }
                    else
                    {
                        descontoINSS = 308.17;
                        porcentagemINSS = "308.17 (teto)";
                    }
                    txtAliqINSS.Text = porcentagemINSS.ToString();
                    txtDescINSS.Text = descontoINSS.ToString();

                    // Cálculo IRPF
                    if (salarioBruto <= 1257.12)
                    {
                        porcentagemIRPF = "isento";
                        descontoIRPF = 0;
                    }
                    else if (salarioBruto <= 2512.08)
                    {
                        porcentagemIRPF = "15.00%";
                        descontoIRPF = salarioBruto * 0.15;
                    }
                    else
                    {
                        porcentagemIRPF = "27.50%";
                        descontoIRPF = salarioBruto * 0.275;
                    }
                    txtDescIRPF.Text = descontoIRPF.ToString();
                    txtAliqIRPF.Text = porcentagemIRPF.ToString();

                    // Salário Família
                    numfilhos = (int)nudNumFilhos.Value;
                    if (salarioBruto <= 435.52)
                        salarioFamilia = 22.33 * numfilhos;
                    else if (salarioBruto <= 654.61)
                        salarioFamilia = 15.74 * numfilhos;
                    else
                        salarioFamilia = 0;
                    txtSalFamilia.Text = salarioFamilia.ToString();

                    // Salário Líquido
                    salarioLiquido = salarioBruto - descontoINSS - descontoIRPF + salarioFamilia;
                    mskbxSalLiquido.Text = salarioLiquido.ToString();
                }

            }
        }
    }
}
