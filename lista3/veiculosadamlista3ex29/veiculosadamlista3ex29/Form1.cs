namespace veiculosadamlista3ex29
{

    public partial class Form1 : Form
    {
        veiculo veiculo=new veiculo();

       
        public Form1()
        {
            InitializeComponent();
        }
        public enum tipoveiculo
        {
            carro=0,
            moto=1,
            caminhao=2,
            desonhecido=3
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Insira o modelo do veículo:");
            string modelo = textBox1.Text;

            veiculo.tipoveiculo tipo = veiculo.obtertipoveiculo(modelo);

            veiculo.exibirtipoveiculo(tipo);






        }
        private tipoveiculo obtertipoveiculo(string modelo)
        {
            if (modelo.ToLower().Contains("carro"))
            {
                return tipoveiculo.carro;
            }
            else if (modelo.ToLower().Contains("moto"))
            {
                return tipoveiculo.moto;
            }
            else if (modelo.ToLower().Contains("caminhao"))
            {
                return tipoveiculo.caminhao;
            }
            else
            {
                return tipoveiculo.desonhecido;
            }
        }
    }
}

