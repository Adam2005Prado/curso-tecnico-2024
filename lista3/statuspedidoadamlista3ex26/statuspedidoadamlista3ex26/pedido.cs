using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statuspedidoadamlista3ex26
{
    public class pedido
    {
        public enum statuspedido
        {
            novo,
            processando,
            enviado,
            entregue
        }
        public statuspedido status { get; private set; }

        public pedido()
        {
            status = statuspedido.novo;
        }
        public void atualizarstatus(statuspedido novostatus)
        {
            status = novostatus;
        }
        public void exibirstatus()
        {
            MessageBox.Show($"Status atual do pedido: {status}");
        }
    }
}
