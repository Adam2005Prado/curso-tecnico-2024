using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula2
{
    public partial class notas : Form
    {
        public notas()
        {
            InitializeComponent();
        }

        private void notas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("campo vazio");
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("campo vazio");
                textBox2.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("campo vazio");
                textBox3.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("campo vazio");
                textBox4.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("campo vazio");
                textBox5.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("campo vazio");
                textBox6.Focus();
                return;

            }
            if (string.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("campo vazio");
                textBox7.Focus();
                return;
            }
            float nota1 = float.Parse(textBox2.Text);
            float nota2 = float.Parse(textBox3.Text);
            float nota3 = float.Parse(textBox4.Text);
            float nota4 = float.Parse(textBox5.Text);
            int dias=Convert.ToInt32(textBox6.Text);
            int  faltas=Convert.ToInt32(textBox7.Text);
            float media = (nota1 + nota2 + nota3 + nota4) / 4;
            if (media > 7)
                MessageBox.Show("Aprovado");
            else if (media >4 && media <= 7)
            {
                MessageBox.Show("Recuperação");
            }
            else { MessageBox.Show("Reprovado");
            }
            float diasp = (dias * 25) / 100;
            if(diasp <= faltas)
            {
                MessageBox.Show("Reprovado por falta");
            }
         
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
