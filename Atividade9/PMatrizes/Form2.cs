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
using System.Text.RegularExpressions;

namespace PMatrizes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            //RA 0030482221032
            string[] nomes = new string[2];
            int[] comprimento = new int[2];

            for (int i = 0; i < 2; i++)
            {
                nomes[i] = Interaction.InputBox($"Digite o nome completo {i + 1}: ");
                if (nomes[i] == "")
                    break;
                else if (!Regex.IsMatch(nomes[i], @"^[a-zA-Z\s'-]+$"))
                {
                    MessageBox.Show("Nome inválido.");
                    i--;
                }
                else
                {
                    comprimento[i] = nomes[i].Replace(" ", "").Length;
                    lstbxLista.Items.Add($"O nome: {nomes[i]} tem {comprimento[i]} caracteres.");
                }
            }
        }
    }
}
