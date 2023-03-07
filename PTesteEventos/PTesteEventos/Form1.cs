using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(13)) // testando se é enter
            {
                SendKeys.Send("{TAB}"); // enviando um tab
                e.Handled = true; // desabilitar o beep
            }
        }

        private void TextBox1_Validated(object sender, EventArgs e)
        {
            if ((textBox2.Text == "") || (textBox2.Text.Length < 20))
            {
                MessageBox.Show("Endereço inválido");
                textBox2.Focus();
            }
        }

        private void TextBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("E-mail vazio");
                e.Cancel = true;
            }
        }

        private void TextBox4_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Saindo do componente do celular");
        }

        private void TextBox5_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("Componente CPF ganhou o foco",
                "texto do título", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);
        }
    }
}
