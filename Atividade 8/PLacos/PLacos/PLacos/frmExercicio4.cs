using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLacos
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnSalarioBruto_Click(object sender, EventArgs e)
        {
            double producao = 0;
            double salario = 0;
            double gratificacao = 0;
            double salarioBruto = 0;
            int b = 0, c = 0, d = 0;

            if (!Double.TryParse(txtProducao.Text, out producao) || !Double.TryParse(txtSalario.Text, out salario)
                || !Double.TryParse(txtGratificacao.Text, out gratificacao))
                MessageBox.Show("Valores Inválidos");
            else
            {
                salarioBruto += salario;
                if (producao >= 100)
                    b = 1;
                if (producao >= 120)
                    c = 1;
                if (producao >= 150)
                    d = 1;
            }
            salarioBruto += salario * (0.05 * b + 0.1 * c + 0.1 * d) + gratificacao;
            if (salarioBruto > 7000 && (producao < 150 || gratificacao == 0))
                MessageBox.Show("Produção deve ser maior ou igual que 150 e deve haver gratificação");
            else
                txtSalarioBruto.Text = salarioBruto.ToString();
        }
    }
}
