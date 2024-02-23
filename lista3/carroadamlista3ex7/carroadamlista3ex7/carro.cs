using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace carroadamlista3ex7
{
    public class carro
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public string descricao {  get; set; }
        public string desc
        {
            get { return $"{marca} {modelo} {descricao}"; }
        }
    }
}