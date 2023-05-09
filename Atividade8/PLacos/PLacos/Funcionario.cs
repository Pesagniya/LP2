using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLacos
{
    class Funcionario
    {
        private string nome;
        private string cargo;
        private int matricula;
        private int producao;
        private double salario;
        private double gratificacao;
    

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public int Producao
        {
            get { return producao; }
            set { producao = value; }
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public double Gratificacao
        {
            get { return gratificacao; }
            set { gratificacao = value; }
        }

        public double SalBruto(double sal, int product, double grats)
        {
            int B = 0, C = 0, D = 0;
            Convert.ToDouble(product);

            if (product >= 150)
            {
                B += 1;
                C += 1;
                D += 1;
            }
            else if (product >= 120)
            {
                B += 1;
                C += 1;
            }
            else if (product >= 100)
                B += 1;

            return sal + sal * (0.05 * B + 0.1 * C + 0.1 * D) + grats;
        }
    }
}
