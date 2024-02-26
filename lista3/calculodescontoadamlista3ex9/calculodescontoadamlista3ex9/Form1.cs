namespace calculodescontoadamlista3ex9
{
    public partial class Form1 : Form
    {
        produto produto = new produto();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            produto.nome = txtnomeproduto.Text;

            if (double.TryParse(txtvalorproduto.Text, out double preco) && 
                double.TryParse(txtdesconto.Text, out double desconto))
            {
                produto.preco = preco;
                produto.desconto = desconto;

                MessageBox.Show($"Pre�o com Desconto do Produto {produto.nome}: {produto.precocomdesconto:C}", "Informa��o", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Por favor, insira valores v�lidos para o pre�o e o desconto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

            }
        }
    }
