using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contabancariaadamlista3ex3
{
    public class contabancaria
    {
        public decimal saldo { get;  set; }
        public decimal limite { get;  set; }
        public decimal sacar(decimal valor)
        {
            if (valor < limite)
            {
                saldo = saldo - valor;
            }
            return saldo;
        }
        public decimal depositar(decimal valor ) {
            saldo=saldo + valor;
            return saldo;
        }

    }
}
