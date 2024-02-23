namespace circuloadamlista3ex5
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

        private void btnDiametro_Click(object sender, EventArgs e)
        {
            Circulo circulo = new Circulo();
            circulo.Raio = Convert.ToDouble( txtRaio.Text);
            MessageBox.Show("diametro " + circulo.Diametro.ToString());
        }
    }
}
