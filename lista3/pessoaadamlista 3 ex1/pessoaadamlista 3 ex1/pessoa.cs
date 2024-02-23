using pessoaadamlista_3_ex1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pessoaadamlista_3_ex1
{
    public class pessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }


        public void Apresentacao()
        {
            MessageBox.Show ($"Olá meu nome é {nome} e tenho {idade} anos.");
        }
    }
}
