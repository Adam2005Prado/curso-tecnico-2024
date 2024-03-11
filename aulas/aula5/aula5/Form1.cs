namespace aula5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexao conn = new conexao();
                if (conn.getconexao() == null)
                {
                    MessageBox.Show("Erro ao conectar!");
                }
                else
                {
                    MessageBox.Show("Conectado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexao conexao = new conexao();
            if (conexao.cadastrar(txtnome.Text,txtemail.Text,txtsenha.Text)>=1)
            {
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro no cadastro!");
            }
        }
    }
}
