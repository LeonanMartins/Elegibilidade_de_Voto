using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condicoes_if_else
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idade;
            idade = Convert.ToInt32(txtIdade.Text);
            if (idade >= 18 && idade <= 64)
                MessageBox.Show("Você é elegível para votar, por ser maior de idade e seu voto é OBRIGATÓRIO!", "TRE", MessageBoxButtons.OK);
            else if (idade <= 15)
                MessageBox.Show("Você ainda não é elegível para Votar, por ser menor de idade.", "TRE", MessageBoxButtons.OK);
            else
                MessageBox.Show("Você é elegível para votar, mas seu voto não é obrigatório.", "TRE", MessageBoxButtons.OK);

            txtIdade.Text = "";

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
