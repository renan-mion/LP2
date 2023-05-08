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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void BtnParDeLetras_Click(object sender, EventArgs e)
        {
            char letraAnterior = '\0';
            int numPares = 0;
            foreach(char letra in rchtxtFrase.Text)
            {
                if (letra == letraAnterior)
                    numPares += 1;

                letraAnterior = letra;
            }
            MessageBox.Show("N° de pares de letras: " + numPares.ToString());
        }

        private void BtnEspacosEmBranco_Click(object sender, EventArgs e)
        {
            int numEspacos = 0;
            for (int c = 0; c < rchtxtFrase.Text.Length; c++)
            {
                if (Char.IsWhiteSpace(rchtxtFrase.Text[c]))
                    numEspacos += 1;
            }
            MessageBox.Show("N° de espaços em branco: " + numEspacos.ToString());
        }

        private void BtnNumeroDeRs_Click(object sender, EventArgs e)
        {
            int numLetrasR = 0;
            int c = 0;
            while (c < rchtxtFrase.Text.Length)
            {
                if (char.ToUpper(rchtxtFrase.Text[c]) == 'R')
                    numLetrasR += 1;
                c++;
            }
            MessageBox.Show("N° de letras R: " + numLetrasR.ToString());
        }
    }
}
