using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace calculodescontoadamlista3ex9
{
    public class produto
    {
        public string nome { get; set; }
        public double desconto { get; set; }
        public double preco { get; set; }

        public double precocomdesconto
        {
            get { return preco - (preco * desconto / 100.0); }
        }
    }
}
