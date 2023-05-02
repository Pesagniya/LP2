using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            string texto = (txtPalindromo.Text.Replace(" ", "")).ToLower();

            if (txtPalindromo.Text.Length > 50)
                MessageBox.Show("Palavra inválida, máximo de 50 caracteres.");
            else
                if (texto.ToArray())
                
        }
    }
}
