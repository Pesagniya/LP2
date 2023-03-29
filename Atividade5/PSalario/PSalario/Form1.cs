using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSalario
{
    public partial class Form1 : Form
    {
        double salBruto, descINSS, descIRPF, salFamily, salLiquido;
        string name;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            if (!Regex.IsMatch(name, "^[A-Za-zÀ-ÖØ-öø-ÿ ]+$") || (name.Length == 1) || (string.IsNullOrWhiteSpace(name)))
            {
                MessageBox.Show("Nome inválido.");
                txtName.Focus();
            }


            if (!double.TryParse(mskbxBruto.Text, out salBruto))
            {
                MessageBox.Show("Salário Bruto inválido.");
                mskbxBruto.Focus();
            }

            //INSS
            if (salBruto <= 800.47)
            {
                mskbxINSS.Text = "7,65%";
                descINSS = 0.0765 * salBruto;
            }
            else if (salBruto <= 1050)
            {
                mskbxINSS.Text = "8,65%";
                descINSS = 0.0865 * salBruto;
            }
            else if (salBruto <= 1400.77)
            {
                mskbxINSS.Text = "9,00%";
                descINSS = 0.09 * salBruto;
            }
            else if (salBruto <= 2801.56)
            {
                mskbxINSS.Text = "11%";
                descINSS = 0.11 * salBruto;
            }
            else
            {
                mskbxINSS.Text = "308,17";
                descINSS = 308.17;
            }

            mskbxDescINSS.Text = Convert.ToString(Math.Round(descINSS, 2));

            //IRPF
            if (salBruto <= 1257.12)
            {
                mskbxIRPF.Text = "0";
                descIRPF = 0;
            }
            else if (salBruto <= 2512.08)
            {
                mskbxIRPF.Text = "15%";
                descIRPF = 0.15 * salBruto;
            }
            else
            {
                mskbxIRPF.Text = "27,5%";
                descIRPF = 0.275 * salBruto;
            }

            mskbxDescIRPF.Text = Convert.ToString(Math.Round(descIRPF, 2));

            //Salario Familia
            if (salBruto <= 435.52)
                salFamily = 22.33 * (double)nudFilhos.Value;
            else if (salBruto <= 654.61)
                salFamily = 15.74 * (double)nudFilhos.Value;
            else
                salFamily = 0;

            mskbxSalFamilia.Text = Convert.ToString(salFamily);

            //Salario Liquido
            salLiquido = salBruto - descINSS - descIRPF + salFamily;
            mskbxLiquido.Text = Convert.ToString(salLiquido);

            if (rbtnMale.Checked)
                lblDados.Text = string.Format("Os descontos do salário do Sr. {0} que é {1} e que tem {2} filho(s)", name, ckbxCasado.Checked?"casado":"solteiro", Convert.ToString(nudFilhos.Value));
            else
                lblDados.Text = string.Format("Os descontos do salário da Sra. {0} que é {1} e que tem {2} filho(s)", name, ckbxCasado.Checked?"casada":"solteira", Convert.ToString(nudFilhos.Value));
        }
    }
}
