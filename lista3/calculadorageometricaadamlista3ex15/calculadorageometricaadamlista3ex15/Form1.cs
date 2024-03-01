namespace calculadorageometricaadamlista3ex15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            calculadorageometrica calculadorageometrica = new calculadorageometrica();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool v1 = double.TryParse(txtlarguraretangulo.Text, out double largura);
            bool v2 = double.TryParse(txtalturaretangulo.Text, out double altura);

            if (v1==true && v2 ==true )
            {
                double resultado = calculadorageometrica.calculoarea(largura, altura);
                MessageBox.Show($"Área do retângulo:{resultado}", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, Insira valores válidos para largura e altura do retângulo", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double resultado;
            if (double.TryParse(txtbasetriangulo.Text, out double basetriangulo) &&
                   double.TryParse(txtalturatriangulo.Text, out double alturatriangulo))
            {
              resultado = calculadorageometrica.calculoarea1(basetriangulo, alturatriangulo);
                MessageBox.Show($"Área do Triângulo: {resultado}", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, insira valores válidos para base e altura do triãngulo", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtraiocirculo.Text,out double raio))
            {
                double resultado = calculadorageometrica.calculoarea(raio);
                MessageBox.Show($"Área do círculo: {resultado}", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Por favor, insira um valor válido para o raio do círculo","Erro!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}

