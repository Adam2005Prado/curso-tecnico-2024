using Csharp_and_Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup2
{
    public partial class Form2 : Form
    {
       

        public Form2(Image image)
        {
            InitializeComponent();
            pictureBox1.Image = image;
            
        }

        public Form2(Form1 Form1)
        {
            InitializeComponent();
            Form1 = Form1;

            // Define o texto da label de destino com base na propriedade do formulário original
            label1.Text = Form1.Original;
        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void label1_Click_1(object sender, EventArgs e)
        {
            //Connection cn = new Connection();
            //string preco = cn.obterdados("Select produto.preco_prod from produto where Cod_prod = 1").ToString();
            //label123.Text = preco;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
