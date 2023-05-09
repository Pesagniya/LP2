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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void BtnSpace_Click(object sender, EventArgs e)
        {
            int space = 0;

            foreach (char i in rchtxtFrase.Text)
                if (i == ' ')
                    space++;
            MessageBox.Show(space.ToString());
        }

        private void BtnR_Click(object sender, EventArgs e)
        {
            int R = 0;

            for (int i = 0; i < rchtxtFrase.Text.Length; i++)
                if (rchtxtFrase.Text[i] == 'R')
                    R++;
            MessageBox.Show(R.ToString());
        }

        private void BtnPair_Click(object sender, EventArgs e)
        {
            int pair = 0;

            rchtxtFrase.Text.Replace(" ", "");
            for (int i = 0; i < rchtxtFrase.Text.Length - 1; i++)
            {
                char first = rchtxtFrase.Text[i];
                char second = rchtxtFrase.Text[i + 1];
                if ((Char.IsLetter(first)) && (Char.IsLetter(second)) && (first == second))
                {
                    pair++;
                    i++;
                }
            }

            MessageBox.Show(pair.ToString());
        }
    }
}
