namespace mediaadamlista3ex13
{
    public partial class Form1 : Form
    {
        matematica matematica = new matematica();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numeros = lernumeros();
            double resultado = matematica.calcular(numeros);

            MessageBox.Show($"Soma dos números: {resultado}", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double[] numeros = lernumeros1();
            double resultado = matematica.calcular(numeros);

            MessageBox.Show($"Média dos números: {resultado}", "Informação",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private int[] lernumeros()
        {
            string[] numerosString=txtnumero1.Text.Split(',');
            return numerosString.Select(s => int.Parse(s.Trim())).ToArray();

        }
        private double[] lernumeros1()
        {
            string[] numerosString = txtnumero1.Text.Split(';');
            return numerosString.Select(s => double.Parse(s.Trim())).ToArray();

        }
    }
}
