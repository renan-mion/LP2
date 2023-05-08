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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void BtnGerarH_Click(object sender, EventArgs e)
        {
            int n;

            if (!int.TryParse(txtNumero.Text, out n))
                MessageBox.Show("Número inválido");
            else if (n <= 0)
                    MessageBox.Show("Número não pode ser igual ou menor que zero");
            else
            {
                double h = 0;
                for (int c = 1; c <= n; c++)
                {
                    h += 1 / (double)c;
                }
                MessageBox.Show("H = " + h.ToString());
            }

        }
    }
}
