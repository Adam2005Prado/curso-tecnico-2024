namespace salariofuncionarioadamlista3ex10
{
    public partial class Form1 : Form
    {

        funcionario funcionario = new funcionario();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            funcionario.nome=txtnomefuncionario.Text;
            if (double.TryParse(txtsalariofuncionario.Text, out double salario))
            {
                funcionario.salario = salario;
                MessageBox.Show($"Salário Anual do Funcionário {funcionario.nome}: {funcionario.salarioanualfuncionario:C}", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, insira um valor válido para o salário.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}