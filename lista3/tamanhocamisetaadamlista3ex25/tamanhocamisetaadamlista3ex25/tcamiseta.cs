using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tamanhocamisetaadamlista3ex25
{
 
    public class tcamiseta
    {  
        public enum tamanhocamiseta
{
    pequeno=0,
    medio=1,
    grande=2
}
        public void exibirtamanho(tamanhocamiseta tamanho)
        { string mensagem = obtermensagemtamanho(tamanho);
            MessageBox.Show(mensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private string obtermensagemtamanho(tamanhocamiseta tamanho)
        {
            string mensagem = "";
            switch (tamanho) { 
                case tamanhocamiseta.pequeno:
                   mensagem= "O tamanho da camiseta é pequeno.";
                    break;

                case tamanhocamiseta.medio:
                    mensagem = "O tamanho da camiseta é médio.";
                    break;
                case tamanhocamiseta.grande:
                    mensagem = "O tamanho da camiseta é grande.";
                    break;

            }
            return mensagem;

        }
    }
}