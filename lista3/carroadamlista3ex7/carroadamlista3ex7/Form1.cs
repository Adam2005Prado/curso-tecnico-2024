namespace carroadamlista3ex7
{
    public partial class Form1 : Form
    {
        carro carro = new carro();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            carro.marca = txtmarca.Text;
            carro.modelo = txtmodelo.Text;
            carro.descricao = txtdescricao.Text;
            
            MessageBox.Show($"Descricao do carro:{carro.desc}", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtdescricao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
