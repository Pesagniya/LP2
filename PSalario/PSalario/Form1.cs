using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSalario
{
    public partial class Form1 : Form
    {
        double bruto, descINSS, descIRPF, SalFamily;


        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //if (char.TryParse(txtName.Text, out name)) // || (txtName.Text.isLetter))
                //MessageBox.Show("Nome inválido.");

            if (!double.TryParse(mskbxBruto.Text, out bruto))
                MessageBox.Show("Salário Bruto inválido.");

            //INSS
            if (bruto <= 800.47)
            {
                mskbxINSS.Text = "7,65%";
                descINSS = 0.0765 * bruto;
            }
            else if (bruto <= 1050)
            {
                mskbxINSS.Text = "8,65%";
                descINSS = 0.0865 * bruto;
            }
            else if (bruto <= 1400.77)
            {
                mskbxINSS.Text = "9,00%";
                descINSS = 0.09 * bruto;
            }
            else if (bruto <= 2801.56)
            {
                mskbxINSS.Text = "11%";
                descINSS = 0.11 * bruto;
            }
            else
            {
                mskbxINSS.Text = "308,17";
                descINSS = 308.17;
            }

            //IRPF
            if (bruto <= 1257.12)
            {
                mskbxIRPF.Text = "0";
                descIRPF = 0;
            }
            else if (bruto <= 2512.08)
            {
                mskbxIRPF.Text = "15%";
                descIRPF = 0.15* bruto;
            }
            else
            {
                mskbxIRPF.Text = "27,5%";
                descIRPF = 0.275 * bruto;
            }

            //Salário Família
            if (bruto <= 435.52)
            {
                SalFamily = 22.33 * Convert.ToDouble(nudFilhos.Value);
                mskbxSalFamilia.Text = Convert.ToString(SalFamily);
            }
        }
    }
}
