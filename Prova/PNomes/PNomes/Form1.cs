using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PNomes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnExecutar_Click(object sender, EventArgs e)
        {

            string[] nomes = new string[3];
            int[] comprimento = new int[3];

            for (int i = 0; i < 3; i++)
            {
                nomes[i] = Interaction.InputBox("Digite o nome completo:");
                if (nomes[i] == string.Empty || nomes[i].Length < 2)
                {
                    MessageBox.Show("Digite um nome válido");
                    i--;
                }
                else
                {
                    comprimento[i] = nomes[i].Replace(" ", "").Length;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                lstbxNomes.Items.Add("O nome: " + nomes[i] + " tem " + comprimento[i] + " caracteres");
            }

        }
    }
}
