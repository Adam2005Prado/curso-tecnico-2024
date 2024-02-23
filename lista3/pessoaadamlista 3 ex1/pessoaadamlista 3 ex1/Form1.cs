namespace pessoaadamlista_3_ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pessoa pessoa = new pessoa();
            pessoa.nome = "Adam";
            pessoa.idade = 18;
            pessoa.Apresentacao();
        }
    }
}
