namespace aulaclasse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            veiculo ve = new veiculo();
            ve.chassi = "ytytyytyty";
            MessageBox.Show("chassi=" + ve.chassi);
            MessageBox.Show("placa " + ve.getplaca());
        }
    }
}
