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

namespace PLacos
{
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void BtnChecar_Click(object sender, EventArgs e)
        {
            string texto = txtPalindromo.Text.Replace(" ", "").ToLower().Normalize(NormalizationForm.FormD); //separates á into a´
            texto = Regex.Replace(texto, @"[\p{M}]", "");        //replaces "´" and others with empty, no idea what [\p{M}] actually means

            string reverse = new string(texto.Reverse().ToArray());                                       

            if ((txtPalindromo.Text.Length > 50) || (!Regex.IsMatch(texto, @"^[a-z]+$")))
                MessageBox.Show("Palavra inválida, máximo de 50 caracteres.");
            else
                if (texto == reverse)
                    MessageBox.Show("A palavra informada é um palíndromo.");
                else
                    MessageBox.Show("A palavra informada não é um palíndromo.");
        }
    }
}
