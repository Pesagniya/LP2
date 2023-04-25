using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClasse
{
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void BtnMensalista_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista();
            objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txtDataEntrada.Text);
            objMensalista.SalarioMensal = Convert.ToDouble(txtSalarioMes.Text);
            if (rbtnNo.Checked)
                objMensalista.HomeOffice = 'N';
            else
                objMensalista.HomeOffice = 'S';

            MessageBox.Show("Matrícula: " + objMensalista.Matricula + "\n" + "Nome: " + objMensalista.NomeEmpregado + "\n" +
                "Data de Entrada: " + objMensalista.DataEntradaEmpresa.ToShortDateString() + "\n" + "Salário Bruto: " + objMensalista.SalarioBruto().ToString("N2") + "\n" +
                "Tempo Empresa (dias): " + objMensalista.TempoTrabalho() + "\n" + objMensalista.VerificaHomeOffice());
        }

        private void BtnMensalista2_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista(Convert.ToInt32(txtMatricula.Text), txtNome.Text, Convert.ToDateTime(txtDataEntrada.Text), Convert.ToDouble(txtSalarioMes.Text));
            if (rbtnNo.Checked)
                objMensalista.HomeOffice = 'N';
            else
                objMensalista.HomeOffice = 'S';

            MessageBox.Show("Matrícula: " + objMensalista.Matricula + "\n" + "Nome: " + objMensalista.NomeEmpregado + "\n" +
                "Data de Entrada: " + objMensalista.DataEntradaEmpresa.ToShortDateString() + "\n" + "Salário Bruto: " + objMensalista.SalarioBruto().ToString("N2") + "\n" +
                "Tempo Empresa (dias): " + objMensalista.TempoTrabalho() + "\n" + objMensalista.VerificaHomeOffice());
        }
    }
}
