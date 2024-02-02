
namespace aula2
{
    public partial class Frmcalculadora : Form
    {
        public Frmcalculadora()
        {
            InitializeComponent();
        }
        //
        private void button1_Click_1(object sender, EventArgs e)
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
            Int32 valor1 = Convert.ToInt32(textBox1.Text);
            Int32 valor2 = Convert.ToInt32(textBox2.Text);
            Int32 soma = valor1 + valor2;
            MessageBox.Show("Resultado :" + soma.ToString());
        }
        private void button2_Click_1(object sender, EventArgs e)
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
            Int32 valor1 = Convert.ToInt32(textBox1.Text);
            Int32 valor2 = Convert.ToInt32(textBox2.Text);
            Int32 subtracao = valor1 - valor2;
            MessageBox.Show("Resultado :" + subtracao.ToString());
        }
        private void button3_Click_1(object sender, EventArgs e)
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
            Int32 valor1 = Convert.ToInt32(textBox1.Text);
            Int32 valor2 = Convert.ToInt32(textBox2.Text);
            Int32 multiplicacao = valor1 * valor2;
            MessageBox.Show("Resultado :" + multiplicacao.ToString());
        }
        private void button4_Click(object sender, EventArgs e)
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
            float valor1 = Convert.ToInt32(textBox1.Text);
            float valor2 = Convert.ToInt32(textBox2.Text);
            float divisao = valor1 / valor2;
            MessageBox.Show("Resultado :" + divisao.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
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
            double raiz = Convert.ToDouble(textBox1.Text);
            MessageBox.Show("Raiz :" + Math.Sqrt(raiz));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text))
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
            double valor= Convert.ToDouble(textBox1.Text);
            double elevado = Convert.ToDouble(textBox2.Text);
            MessageBox.Show("potencia " + Math.Pow(valor, elevado));
        }
    }
}
