using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteComponentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("ADS");
            listBox1.Items.Add("SBIO");
            listBox1.Items.Add("Projetos Mecânicos");
            listBox1.Items.Add("Processos Metalúrgicos");
            listBox1.Items.Add("Polímeros");
            listBox1.Items.Add("Fabricação");

            listBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="") //if (textBox1.Text==String.Empty)
                MessageBox.Show("Nome está vazio!");

            //if (checkBox1.Checked)
            //    MessageBox.Show("Turma manhã");
            //else
            //    MessageBox.Show("Turma noite");

            if (checkBox1.CheckState==CheckState.Checked)
                MessageBox.Show("Turno manhã");
            else if (checkBox1.CheckState==CheckState.Unchecked)
                MessageBox.Show("Turno noite");
            else
                MessageBox.Show("Turno indefinido");


            if (comboBox1.SelectedIndex==-1)
                MessageBox.Show("Não selecionou a turma!");
            else
                MessageBox.Show(comboBox1.SelectedItem.ToString());

            DateTime dtTeste;

            if (DateTime.TryParse(maskedTextBox1.Text, out dtTeste))
                MessageBox.Show("Data válida:"+dtTeste.ToString());
            else
                MessageBox.Show("Data inválida");

            if (radioButton1.Checked)
                MessageBox.Show("Veio transferido");
            else
                MessageBox.Show("Não veio transferido");

            //for (var x=0; x<=checkedListBox1.CheckedItems.Count-1; x++)
            //    MessageBox.Show(checkedListBox1.CheckedItems[x].ToString());
            
            string stringona="";
            for (var x = 0; x <= checkedListBox1.CheckedItems.Count - 1; x++)
                stringona = stringona + "\n" + 
                    checkedListBox1.CheckedItems[x].ToString();

            MessageBox.Show(stringona);





        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
