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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void BtnGerar_Click(object sender, EventArgs e)
        {
            double H = 0;
            if ((!int.TryParse(txtN.Text, out int N)) || (Convert.ToInt32(txtN.Text) == 0))
                MessageBox.Show("N é um input inválido.");
            else
            {
                for (int i = 0; i < N; i++)
                    H += 1.0 / (i + 1);
                MessageBox.Show(H.ToString("N2"));
            }
        }
    }
}
