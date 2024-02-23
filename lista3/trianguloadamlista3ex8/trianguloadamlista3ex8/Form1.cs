namespace trianguloadamlista3ex8
{
    public partial class Form1 : Form
    {
        triangulo triangulo = new triangulo();

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
            if(
            double.TryParse(txtladoa.Text,out double ladoA)&&
            double.TryParse(txtladob.Text, out double ladoB)&&
            double.TryParse(txtladoc.Text,out double ladoC))
            {
                triangulo.ladoA= ladoA;
                triangulo.ladoB = ladoB;
                triangulo.ladoC= ladoC;
                MessageBox.Show($"Perímetro do Triângulo: {triangulo.perimetro}", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Por favor, insira valores válidos para os lados do triângulo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
