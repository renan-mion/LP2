using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMenu
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCaracterNumerico_Click(object sender, EventArgs e)
        {

            int pos;
            int cont = 0;
            for (pos = 0; pos <= rtxCaracteres.Text.Length - 1; pos++)
            {
                if (Char.IsNumber(rtxCaracteres.Text[pos]))
                    cont++;
            }

            MessageBox.Show("Este texto tem " + cont + " caracteres numéricos");
        }

        private void btnCaracterBranco_Click(object sender, EventArgs e)
        {
            int pos = 0;
            while (pos <= rtxCaracteres.Text.Length - 1)
            {
                if (Char.IsWhiteSpace(rtxCaracteres.Text[pos]))
                    break;
                else
                    pos++;
            }

            MessageBox.Show("O primeiro caracter branco está na posição " + pos);
        }

        private void btnCaracterAlfabetico_Click(object sender, EventArgs e)
        {
            int cont = 0;
            foreach (char caracter in rtxCaracteres.Text)
            {
                if (Char.IsLetter(caracter))
                    cont++;
            }

            MessageBox.Show("Este texto tem " + cont + " caracteres alfabéticos");
        }
    }
}
