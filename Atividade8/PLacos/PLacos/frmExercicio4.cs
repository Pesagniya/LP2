using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PLacos
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void mskbxNome_Validated(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(mskbxNome.Text, @"\p{L}"))
            {
                MessageBox.Show("Nome inválido.");
                mskbxNome.Clear();
                mskbxNome.Focus();
            }
        }

        private void mskbxCargo_Validated(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(mskbxCargo.Text, @"\p{L}"))
            {
                MessageBox.Show("Cargo inválido.");
                mskbxCargo.Clear();
                mskbxCargo.Focus();
            }
        }

        private void mskbxMatricula_Validated(object sender, EventArgs e)
        {
            if ((mskbxMatricula.Text.Replace(" ","") == "0") || (String.IsNullOrWhiteSpace(mskbxMatricula.Text)))
            {
                MessageBox.Show("Matrícula inválida.");
                mskbxMatricula.Clear();
                mskbxMatricula.Focus();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Funcionario objFuncionario = new Funcionario();
            objFuncionario.Nome = mskbxNome.Text;
            objFuncionario.Cargo = mskbxCargo.Text;
            int.TryParse(mskbxMatricula.Text, out int matricula);
            objFuncionario.Matricula = matricula;
            int.TryParse(mskbxProducao.Text, out int producao);
            objFuncionario.Producao = producao;
            double.TryParse(mskbxSal.Text, out double salario);
            objFuncionario.Salario = salario;
            double.TryParse(mskbxGratif.Text, out double gratificacao);
            objFuncionario.Gratificacao = gratificacao;

            double SalFunc = objFuncionario.SalBruto(objFuncionario.Salario, objFuncionario.Producao, objFuncionario.Gratificacao);
            MessageBox.Show("R$" + SalFunc.ToString("N2"));
        }

        private void mskbxProducao_Validated(object sender, EventArgs e)
        {
            if ((mskbxProducao.Text.Replace(" ", "") == "0") || (String.IsNullOrWhiteSpace(mskbxProducao.Text)))
            {
                MessageBox.Show("Produção inválida.");
                mskbxProducao.Clear();
                mskbxProducao.Focus();
            }
        }

        private void mskbxSal_Validated(object sender, EventArgs e)
        {
            if ((mskbxSal.Text.Replace(" ", "") == "0") || (String.IsNullOrWhiteSpace(mskbxSal.Text)))
            {
                MessageBox.Show("Salário inválido.");
                mskbxSal.Clear();
                mskbxSal.Focus();
            }
        }
    }
}
