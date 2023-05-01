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
using System.Collections;

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
                if (aux == "") //cancel or close window
                    break;
                else if (!int.TryParse(aux, out vetor[i])) //validation
                {
                    MessageBox.Show("Número inválido.");
                    i--;
                }
                else
                    saida = vetor[i].ToString() + "\n" + saida; //add left of saida
            }

            MessageBox.Show("Ordem inversa:\n" + saida);
        }

        private void BtnEx2_Click(object sender, EventArgs e)
        {
            int[] Quantidade = new int[10];
            double[] Preços = new double[10];
            string aux;
            bool close = false;

            for (int i = 0; i < 10; i++)
            {
                if (close) //change by nested loop
                    break;

                aux = Interaction.InputBox("Digite a quantidade do item " + (i + 1).ToString(), "Entrada de dados");
                if (aux == "")
                    break;
                else if (!int.TryParse(aux, out Quantidade[i]))
                {
                    MessageBox.Show("Quantidade inválida.");
                    i--;
                }
                else
                    while (true)
                    {
                        aux = Interaction.InputBox("Digite o preço do item " + (i + 1).ToString(), "Entrada de dados");
                        if (aux == "")
                        {
                            close = true;
                            break;
                        }
                        else if ((!double.TryParse(aux, out Preços[i])) || (Convert.ToDouble(aux) == 0))
                            MessageBox.Show("Preço inválido.");
                        else //if not close or invalid, continue for loop w/ break
                            break;
                    }
            }

            aux = "";
            for (int i = 0; i < 10; i++)
                aux += $"\nItem {i+1}: R${(Quantidade[i] * Preços[i]):F2}";
            MessageBox.Show("Faturamento mensal:\n" + aux);
        }

        private void btnEx3_Click(object sender, EventArgs e)
        {
            string[] Alunos = { "Viviane", "André", "Hélio", "Denise", "Junior", "Leonardo", "Jose", "Nelma", "Tobby" }; 
            Int32 I, Total = 0; 
            Int32 N = Alunos.Length; 
            
            for (I = 0; I < N - 1; I++) { 
                Total += Alunos[I].Length; 
            }
            MessageBox.Show(Total.ToString());
        }

        private void btnEx4_Click(object sender, EventArgs e)
        {
            ArrayList alunos = new ArrayList() { "Ana", "André", "Débora", "Fátima", "João", "Janete", "Otávio", "Marcelo", "Pedro", "Thais" };
            alunos.Remove("Otávio");
            MessageBox.Show(String.Join(", ", alunos.ToArray()) + ".");
        }

        private void btnEx5_Click(object sender, EventArgs e)
        {
            double[,] notas = new double[20, 3];
            double media;
            string nota, lista = "";
            bool close = false;

            for (int i = 0; i < 20; i++)
            {
                if (close)
                    break;
                for (int j = 0; j < 3; j++)
                {
                    nota = Interaction.InputBox($"Digite a nota {j + 1} do aluno {i + 1}:");
                    if (nota == "")
                    {
                        close = true;
                        break;
                    }
                    else if (!double.TryParse(nota, out notas[i, j]))
                    {
                        MessageBox.Show("Nota inválida.");
                        j--;
                    }
                }
            }

            for (int i = 0; i < 20; i++)
            {
                media = (notas[i, 0] + notas[i, 1] + notas[i, 2]) / 3;
                lista += $"Aluno {i + 1}: média {media:F1}\n";
            }

            MessageBox.Show(lista);
        }

        private void btnEx6_Click(object sender, EventArgs e)
        {
            Form2 objForm2 = new Form2();
            objForm2.Show();
        }
    }
}