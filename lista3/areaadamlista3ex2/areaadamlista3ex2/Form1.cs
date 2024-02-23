namespace areaadamlista3ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            retangulo retangulo = new retangulo();
            retangulo.largura = 5.0;
            retangulo.altura = 10.0;
            retangulo.Areacalculo();
        }
    }
}
