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
                MessageBox.Show($"Per�metro do Tri�ngulo: {triangulo.perimetro}", "Informa��o", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Por favor, insira valores v�lidos para os lados do tri�ngulo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
