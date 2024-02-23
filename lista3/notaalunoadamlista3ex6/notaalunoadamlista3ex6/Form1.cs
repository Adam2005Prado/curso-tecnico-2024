namespace notaalunoadamlista3ex6
{
    public partial class Form1 : Form
    {
        Notaaluno notaaluno = new Notaaluno();

        public Form1()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Média_Click(object sender, EventArgs e)
        {
            notaaluno.Nome = txtnome.Text;

            if (double.TryParse(txtnota1.Text, out double nota1) &&
                double.TryParse(txtnota2.Text, out double nota2) &&
                double.TryParse(txtnota3.Text, out double nota3))
            {
               notaaluno.Notas = new double[] { nota1, nota2, nota3 };

                MessageBox.Show($"A média do aluno {notaaluno.Nome} é: {notaaluno.Media}", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, insira notas válidas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}