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
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void BtnHorista_Click(object sender, EventArgs e)
        {
            Horista objHorista = new Horista();
            objHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objHorista.NomeEmpregado = txtNome.Text;
            objHorista.SalarioHora = Convert.ToDouble(txtSalarioHora.Text);
            objHorista.NumeroHora = Convert.ToDouble(txtHoras.Text);
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txtDataEntrada.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtFaltas.Text);
            if (rbtnNo.Checked)
                objHorista.HomeOffice = 'N';
            else
                objHorista.HomeOffice = 'S';

            MessageBox.Show("Matrícula: " + objHorista.Matricula + "\n" + "Nome: " + objHorista.NomeEmpregado + "\n" +
                "Data de Entrada: " + objHorista.DataEntradaEmpresa.ToShortDateString() + "\n" + "Salário Bruto: " + objHorista.SalarioBruto().ToString("N2") + "\n" +
                "Tempo Empresa (dias): " + objHorista.TempoTrabalho() + "\n" + objHorista.VerificaHomeOffice());
        }
    }
}
