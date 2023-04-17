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

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random lottery = new Random();
            bool valid1, valid2;
            valid1 = int.TryParse(txtNum1.Text, out int num1);
            valid2 = int.TryParse(txtNum2.Text, out int num2);
            // o primeiro e o ultimo numero nao conta na loteria
            if ((valid1) && (valid2) && (num2 > num1) && (num2 - num1 > 1)) 
                MessageBox.Show(String.Format("O número sorteado é {0}", lottery.Next(num1+1, num2)));
            else
                MessageBox.Show("Entrada inválida.");
        }
    }
}
