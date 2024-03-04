namespace veiculosadamlista3ex29
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public enum tipoveiculo
        {
            carro,
            moto,
            caminhao,
            desonhecido
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string modelo = textBox1.Text;
            TipoVeiculo tipo = ObterTipoVeiculo(modelo);

            exibirtipoveiculo(tipo);
        }
        private tipoveiculo obtertipoveiculo(string modelo)
        {
            if (modelo.ToLower().Contains("carro"))
            {
                return tipoVeiculo.Carro;
            }
            else if (modelo.ToLower().Contains("moto"))
            {
                return TipoVeiculo.Moto;
            }
            else if (modelo.ToLower().Contains("caminhao"))
            {
                return TipoVeiculo.Caminhao;
            }
            else
            {
                return TipoVeiculo.Desconhecido;
            }
        }
    }
}

