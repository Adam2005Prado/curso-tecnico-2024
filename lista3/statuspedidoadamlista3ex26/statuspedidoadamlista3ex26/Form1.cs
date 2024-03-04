namespace statuspedidoadamlista3ex26
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

        private void button1_Click(object sender, EventArgs e)
        {
            pedido meupedido = new pedido();
            switch (
                Convert.ToInt32(textBox1.Text))
            {
                case 0:
                    meupedido.atualizarstatus(pedido.statuspedido.processando);
                    meupedido.exibirstatus();
                    break;

                case 1:
                    meupedido.atualizarstatus(pedido.statuspedido.enviado);
                    meupedido.exibirstatus();
                    break;

                case 2:
                    meupedido.atualizarstatus(pedido.statuspedido.entregue);
                    meupedido.exibirstatus();
                    break;
                    
            }
            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
