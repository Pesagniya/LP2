using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTriangulo
{
    public partial class Form1 : Form
    {
        double ladoa, ladob, ladoc;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

            double.TryParse(txtA.Text, out ladoa);
            double.TryParse(txtB.Text, out ladob);
            double.TryParse(txtC.Text, out ladoc);

            if ((ladoa < (ladob + ladoc)) && (ladoa > Math.Abs(ladob - ladoc)) ||
               (ladob < (ladoa + ladoc)) && (ladob > Math.Abs(ladoa - ladoc)) ||
               (ladoc < (ladoa + ladob)) && (ladoc > Math.Abs(ladoa - ladob)))
                if (ladoa != ladob && ladoa != ladob && ladoc != ladoa)
                    MessageBox.Show("Triângulo escaleno.");
                else if (ladoa != ladob || ladoa != ladob || ladoc != ladoa)
                    MessageBox.Show("Triângulo isósceles.");
                else
                    MessageBox.Show("Triângulo equilátero.");
            else
                MessageBox.Show("Não forma um triângulo.");
        }
    }
}