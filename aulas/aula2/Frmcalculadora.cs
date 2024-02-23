
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
            validar();
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
            validar();
            double valor = Convert.ToDouble(textBox1.Text);
            double elevado = Convert.ToDouble(textBox2.Text);
            MessageBox.Show("potencia " + Math.Pow(valor, elevado));
        }

        private void button7_Click(object sender, EventArgs e)
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
            double a = Convert.ToInt32(textBox1.Text);
            double b = Convert.ToInt32(textBox2.Text); double delta, xl, xll, raizq;
            double c = Convert.ToInt32(textBox3.Text);
            MessageBox.Show("A B C " + textBox1.Text + textBox2.Text + textBox3.Text);

            delta = (b * b) * (-4) * a * c;

            raizq = Math.Sqrt(delta);
            MessageBox.Show("Raiz " + raizq.ToString());
            xl = ((-b) + raizq) / 2 * a;
            xll = ((-b) - raizq) / 2 * a;

            MessageBox.Show("O resultado do x linha é :" + xl);
            MessageBox.Show("Já o resultado de x duas linha é:" + xll);
            if (delta > 0)
            {
                MessageBox.Show("Há duas raízes iguais ou distintas");
            }
            else if (delta < 0)
            {
                MessageBox.Show("Não há raiz");
            }
            else
            {
                MessageBox.Show("Há duas raízes iguais ou distintas");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("campo vazio");
                textBox1.Focus();
                return;
            }
            double a = Convert.ToInt32(textBox1.Text);
            double log = Math.Log(a);
            MessageBox.Show("O log é: " + log.ToString());


        }
        public bool validar()
        {
            bool testa = false;
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("campo vazio");
                textBox1.Focus();
                testa = true;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("campo vazio");
                textBox2.Focus();
                testa = true;
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("campo vazio");
                textBox3.Focus();
                testa = true;
            }
            return testa;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 pri = new Form2();
            pri.ShowDialog();
        }

        private void Frmcalculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
