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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnPalindromo_Click(object sender, EventArgs e)
        {
            string palavra = "";
            string palavra2 = "";
            for (int c = 0; c < txtPalindromo.Text.Length; c++)
            {
                if (!char.IsWhiteSpace(txtPalindromo.Text[c]))
                    palavra += char.ToUpper(txtPalindromo.Text[c]);
            }

            for (int c = txtPalindromo.Text.Length - 1; c >= 0; c--)
            {
                if (!char.IsWhiteSpace(txtPalindromo.Text[c]))
                    palavra2 += char.ToUpper(txtPalindromo.Text[c]);
            }

            if (palavra == palavra2)
                MessageBox.Show("É palíndromo");
            else
                MessageBox.Show("Não é palíndromo");
        }
    }
}
