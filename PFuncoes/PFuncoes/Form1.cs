using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFuncoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Soma1()
        {
            double resultado = 2 + 1;
            MessageBox.Show(resultado.ToString());
        }

        private void BtnSoma1_Click(object sender, EventArgs e)
        {
            Soma1();
        }

        double Soma2()
        {
            double resultado = 2 + 3;
            return resultado;
        }

        private void BtnSoma2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Soma2().ToString());
        }

        void Soma3(double x, double y)
        {
            x = 40;
            double resultado = x + y;
            MessageBox.Show("O resultado é: " + resultado.ToString());
        }

        private void BtnSoma3_Click(object sender, EventArgs e)
        {
            double a = 10;
            double b = 20;

            Soma3(a, b);
            MessageBox.Show("Valor de a: " + a + "\nValor de b: " + b);
        }

        double Soma4(double x, double y)
        {
            double resultado = x + y;
            return resultado;
        }

        private void BtnSoma4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Soma4(10, 20).ToString());
        }

        void Soma5(ref double resultado, ref double a)
        {
            resultado = 2 + 3;
            a = 40;
        }

        private void BtnSoma5_Click(object sender, EventArgs e)
        {
            double a = 10, b = 20;
            Soma5(ref a, ref b);
            MessageBox.Show("Valor de a: " + a + "\nValor de b: " + b);
        }

        double Soma6(ref double resultado)
        {
            resultado = 2 + 3;
            return resultado;
        }

        private void BtnSoma6_Click(object sender, EventArgs e)
        {
            double r = 0;
            MessageBox.Show(Soma6(ref r).ToString());
            MessageBox.Show(r.ToString());
        }

        void Soma7(out double resultado)
        {
            resultado = 2 + 3;
        }

        private void BtnSoma7_Click(object sender, EventArgs e)
        {
            double a = 50;
            Soma7(out a);
            MessageBox.Show(a.ToString());
        }

        double Soma8(out double resultado)
        {
            resultado = 2 + 3;
            return resultado;
        }

        private void BtnSoma8_Click(object sender, EventArgs e)
        {
            double a = 50;
            MessageBox.Show(Soma8(out a).ToString());
            MessageBox.Show(a.ToString());
        }

        void Soma9(out double retorno, double x, double y, double z = 0)
        {
            if (z > 0)
                retorno = (x + y + z) / 3;
            else
                retorno = (x + y) / 2;
        }

        private void BtnSoma9_Click(object sender, EventArgs e)
        {
            double r = 0;
            Soma9(out r, 10, 20, 30);
            MessageBox.Show(r.ToString());
        }
    }
}
