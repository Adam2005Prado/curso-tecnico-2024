namespace contabancariaadamlista3ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contabancaria bc =new contabancaria();
            bc.saldo = 1000;
            bc.limite = 100;
            MessageBox.Show("Saque"+bc.sacar(100).ToString());
            MessageBox.Show("Deposito" + bc.depositar(50).ToString());
        }
    }
}
