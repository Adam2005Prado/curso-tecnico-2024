namespace calculadorasomaadamlista3ex11
{
    public partial class Form1 : Form
    {
        calculadora calculadora = new calculadora();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(valor1double.Text, out double numero1) &&
                double.TryParse(valor2double.Text, out double numero2))
            {
                double resultado = calculadora.somar(numero1, numero2);
                MessageBox.Show($"Resultado da soma de decimais: {resultado}", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, insira números decimais válidos.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(valorinteiro1.Text, out int numero1) &&
               int.TryParse(valorinteiro2.Text, out int numero2))
            {
                int resultado = calculadora.somar(numero1, numero2);
                MessageBox.Show($"Resultado da soma de inteiros: {resultado}", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, insira números inteiros válidos.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
