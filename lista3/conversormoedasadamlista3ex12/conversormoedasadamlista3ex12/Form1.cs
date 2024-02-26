namespace conversormoedasadamlista3ex12
{
    public partial class Form1 : Form
    {
        conversor conversor = new conversor();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(moedadolar.Text, out double valoremDolares))
            {
                double resultado = conversor.converterparaReais(valoremDolares, Convert.ToDouble(taxacambio1.Text));
                MessageBox.Show($"Valor em Reais: {resultado:C}", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Insira um valor válido em dólares.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(moedareal.Text, out double valoremReais))
            {
                double resultado = conversor.converterparaDolares(valoremReais, Convert.ToDouble(taxacambio2.Text));
                MessageBox.Show($"Valor em Dólares: {resultado:C}", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Insira um valor válido em reais.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}