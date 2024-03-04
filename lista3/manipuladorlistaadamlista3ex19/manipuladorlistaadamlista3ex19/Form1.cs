namespace manipuladorlistaadamlista3ex19
{
   

    public partial class Form1 : Form
    {
        private ListBox lstlementos;
        private manipuladorlista manipuladorlista;
        private List<int> minhalista;
        public Form1()
        {
            manipuladorlista = new manipuladorlista();
            minhalista = new List<int>();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int elemento))
            {
                minhalista.Add(elemento);
                MessageBox.Show("elemeneto adicionado!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBox1.Items.Add(elemento);//exibir na lista o valor
            }
            else
            {
                MessageBox.Show("Por favor, insira um número inteiro válido.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox3.Text, out int indice))
            {
                manipuladorlista.removerelemento(minhalista, indice);
                atualizarlstbox();
                MessageBox.Show("Elemento removido!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBox1.Items.Remove(indice);
            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido para remover. ", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox4.Text, out int indice))
            {
                manipuladorlista.removerelemento1(minhalista, indice);
                atualizarlstbox();
                MessageBox.Show("Elemento removido pelo índice!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBox1.Items.Remove(indice);
            }
            else
            {
                MessageBox.Show("Por favor, insira um índice válido para remover.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void atualizarlstbox()
        {

            minhalista.Clear();


            //  lstlementos.Items.Clear();
            foreach (int tem in minhalista)
            { minhalista.Add(tem); }


        }
    }
}
       