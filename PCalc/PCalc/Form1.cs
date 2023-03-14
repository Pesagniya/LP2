using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalc
{
    public partial class Form1 : Form
    {
        double num1, num2, result;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResult.Clear();
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            if ((Double.TryParse(txtNum2.Text, out num2)) && (Double.TryParse(txtNum1.Text, out num1)))
            {
                result = num1 + num2;
                txtResult.Text = result.ToString();
            }
            else
                MessageBox.Show("Número(s) inválido(s).");
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            if ((Double.TryParse(txtNum2.Text, out num2)) && (Double.TryParse(txtNum1.Text, out num1)))
            {
                result = num1 - num2;
                txtResult.Text = result.ToString();
            }
            else
                MessageBox.Show("Número(s) inválido(s).");
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            if ((Double.TryParse(txtNum2.Text, out num2)) && (Double.TryParse(txtNum1.Text, out num1)))
            {
                result = num1 * num2;
                txtResult.Text = result.ToString();
            }
            else
                MessageBox.Show("Número(s) inválido(s).");
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            if ((Double.TryParse(txtNum2.Text, out num2)) && (Double.TryParse(txtNum1.Text, out num1)) && num2 != 0)
            {
                result = num1 / num2;
                txtResult.Text = result.ToString();
            }
            else
                MessageBox.Show("Número(s) inválido(s).");
        }

        private void TxtNum2_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtNum2.Text, out num2))
                MessageBox.Show("Número inválido.");
        }

        private void TxtNum1_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtNum1.Text, out num1))
                MessageBox.Show("Número inválido.");
        }
    }
}
