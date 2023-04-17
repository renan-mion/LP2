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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnSorteio_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int result1;
            int result2;
            if (!(int.TryParse(txtNumero1.Text, out result1)) || !(int.TryParse(txtNumero2.Text, out result2)))
                txtResultado.Text = "Número(s) inválidos";
            else
            {
                int resultado = random.Next(result1, result2);
                txtResultado.Text = resultado.ToString();
            }
        }
    }
}
