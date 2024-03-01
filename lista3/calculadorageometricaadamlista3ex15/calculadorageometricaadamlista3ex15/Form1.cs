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
                MessageBox.Show($"�rea do ret�ngulo:{resultado}", "Informa��o", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, Insira valores v�lidos para largura e altura do ret�ngulo", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double resultado;
            if (double.TryParse(txtbasetriangulo.Text, out double basetriangulo) &&
                   double.TryParse(txtalturatriangulo.Text, out double alturatriangulo))
            {
              resultado = calculadorageometrica.calculoarea1(basetriangulo, alturatriangulo);
                MessageBox.Show($"�rea do Tri�ngulo: {resultado}", "Informa��o", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, insira valores v�lidos para base e altura do tri�ngulo", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtraiocirculo.Text,out double raio))
            {
                double resultado = calculadorageometrica.calculoarea(raio);
                MessageBox.Show($"�rea do c�rculo: {resultado}", "Informa��o", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Por favor, insira um valor v�lido para o raio do c�rculo","Erro!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}

