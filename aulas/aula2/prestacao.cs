using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula2
{
    public partial class prestacao : Form
    {
        public prestacao()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void prestacao_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          float prestacao=float.Parse(textBox1.Text);
            float tempo=float.Parse(textBox2.Text);
            float taxa=float.Parse(textBox3.Text);
            float vprestacao = prestacao + (prestacao * (taxa / 100) * tempo);
            MessageBox.Show("O valor da prestação atrasada é: " + vprestacao.ToString());


        }
    }
}
