using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaclasse
{
    internal class veiculo
    {
       public string chassi;
        private string modelo;
        protected string placa;
        
        public veiculo()
        {
            modelo = "";

        }

        public string getplaca()
        {
            placa = "rer123";
            return placa;

        }

    }
}
