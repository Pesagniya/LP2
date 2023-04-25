using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PMatrizes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            string aux, saida = "";

            for (int i = 0; i < 20; i++)
            {
                aux = Interaction.InputBox("Digite o número " + (i+1).ToString(), "Entrada de dados");
                if (!int.TryParse(aux, out vetor[i]))
                {
                    MessageBox.Show("Número inválido.");
                    i--;
                }
                else
                    saida = vetor[i].ToString() + "\n" + saida;
            }
            MessageBox.Show(saida);
        }

        private void BtnEx2_Click(object sender, EventArgs e)
        {
            int[] Quantidade = new int[10];
            string aux = "";

            for (int i = 0; i < 20; i++)
            {
                aux = Interaction.InputBox("Digite o número " + (i + 1).ToString(), "Entrada de dados");
                if (!int.TryParse(aux, out Quantidade[i]))
                {
                    MessageBox.Show("Número inválido.");
                    i--;
                }
                else
                    while (Preco < 0)
            }

        private void BtnEx3_Click(object sender, EventArgs e)
        {

        }

        private void BtnEx4_Click(object sender, EventArgs e)
        {

        }

        private void BtnEx5_Click(object sender, EventArgs e)
        {

        }
    }
}
