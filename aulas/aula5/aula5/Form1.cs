namespace aula5
{
    public partial class Form1 : Form
    {
        int codigo = 0;
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
            if (conexao.cadastrar(txtnome.Text, txtemail.Text, txtsenha.Text) >= 1)
            {
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro no cadastro!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            label1.Text = codigo.ToString();
            txtnome.Text = dataGridView1.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtemail.Text = dataGridView1.Rows[e.RowIndex].Cells["email"].Value.ToString();
            txtsenha.Text = dataGridView1.Rows[e.RowIndex].Cells["senha"].Value.ToString();

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (codigo > 0)
            {
                usuario usuario = new usuario();
                if (usuario.alterar(txtemail.Text, txtnome.Text, txtsenha.Text, codigo) > 0)
                    MessageBox.Show("Alterado com sucesso.");

                else
                {
                    MessageBox.Show("Erro ao alterar os dados.");
                }
            }
            else
                MessageBox.Show("Não selecionou o usuário. ");

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            usuario usuario= new usuario();
            if(usuario.excluir(codigo)>0)
            {
                MessageBox.Show("Usuário excluído com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao excluir");
            }
        }
    }
}
