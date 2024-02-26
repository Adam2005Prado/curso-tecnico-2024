using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace salariofuncionarioadamlista3ex10
{
    public class funcionario
    {
        public string nome {  get; set; }
        public double salario { get; set;}

        public double salarioanualfuncionario
        {
            get { return salario*12; }
        }
    }
}
