using Csharp_and_Database;

namespace Backup2
{
    public partial class Form1 : Form
    {

        Image produto;
        
        

        public Form1()
        {
            InitializeComponent();
        }

        public string Original
        {
             get { return label1.Text; }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            produto = pictureBox2.Image;
            Form2 form2 = new Form2(produto);
            form2.ShowDialog();
            label1.Text = cn.obterdados("Select produto.preco_prod from produto where Cod_prod = 1").ToString();

            //Connection cn = new Connection();
            //string preco = cn.obterdados("Select produto.preco_prod from produto where Cod_prod = 1").ToString();
            //label123.Text = preco;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            produto = pictureBox3.Image;
            Form2 form2 = new Form2(produto);
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            produto = pictureBox4.Image;
            Form2 form2 = new Form2(produto);
            form2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            produto = pictureBox5.Image;
            Form2 form2 = new Form2(produto);
            form2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            produto = pictureBox6.Image;
            Form2 form2 = new Form2(produto);
            form2.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            produto = pictureBox7.Image;
            Form2 form2 = new Form2(produto);
            form2.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            produto = pictureBox8.Image;
            Form2 form2 = new Form2(produto);
            form2.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            produto = pictureBox9.Image;
            Form2 form2 = new Form2(produto);
            form2.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {


            // prod = label1.Text;
            //Form2 form2 = new Form2(prod);
            //form2.ShowDialog();

        }
    }
}
