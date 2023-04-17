using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMenu
{
    public partial class frmExercicio4 : Form
    {
        int i, n;
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = 0;
            while (i < rchtxtTexto.Text.Length)
                if (Char.IsWhiteSpace(rchtxtTexto.Text[i]))
                {
                    i++;
                    break;
                }
                else
                    i++;

            if (i > 0)
                MessageBox.Show(string.Format("O primeiro espaço está na {0}º posição.", i.ToString()));
            else
                MessageBox.Show("O texto não tem espaço");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (i = 0, n = 0; i < rchtxtTexto.Text.Length; i++)
                if (Char.IsNumber(rchtxtTexto.Text[i]))
                    n++;

            MessageBox.Show(string.Format("O texto tem {0} número(s).", n.ToString()));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n = 0;
            foreach(char i in rchtxtTexto.Text)
                if (Char.IsLetter(i))
                    n++;

            MessageBox.Show(string.Format("O texto tem {0} letra(s).", n.ToString()));
        }
    }
}
