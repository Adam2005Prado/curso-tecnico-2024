namespace comparadoradamlista3ex16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            comparador comparador = new comparador();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtnum1inteiro.Text, out int num1) &&
                int.TryParse(txtnum2inteiro.Text, out int num2))
            {
                int resultado = comparador.maior(num1, num2);
                MessageBox.Show($"O maior número inteiro é: {resultado}", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor insira números inteiros válidos.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtnum1decimal.Text, out double num1) &&
                double.TryParse(txtnum2decimal.Text, out double num2))
            {
                double resultado = comparador.maior(num1, num2);
                MessageBox.Show($"O maior número decimal é: {resultado}", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor insira números decimais válidos.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
    }
}

