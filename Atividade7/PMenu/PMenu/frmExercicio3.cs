﻿using System;
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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            int posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);

            if (txtPalavra1.Text == "")
                ;
            else
                while (posicao >= 0)
            {
                txtPalavra2.Text = txtPalavra2.Text.Substring(0, posicao) + txtPalavra2.Text.Substring(posicao + txtPalavra1.Text.Length, txtPalavra2.Text.Length - txtPalavra1.Text.Length - posicao);
                posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
            }
        }

        private void BtnReplace_Click(object sender, EventArgs e)
        {
            if (txtPalavra1.Text == "")
                ;
            else
                txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");
        }

        private void BtnReverse_Click(object sender, EventArgs e)
        {
            char[] vetor = txtPalavra1.Text.ToCharArray();
            Array.Reverse(vetor);

            string retorno = string.Join("", vetor);
            MessageBox.Show(retorno);
        }
    }
}
