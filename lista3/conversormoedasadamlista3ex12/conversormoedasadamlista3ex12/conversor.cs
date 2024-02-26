using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversormoedasadamlista3ex12
{
    public class conversor
    {
        ///ublic const double taxcambio = 4.99; //taxa do câmbio pode variar, este valor é do dia 26/02/2024\\

        public double converterparaReais(double valoremDolares, double taxcambio)
        {
            return valoremDolares * taxcambio;
        }
        public double converterparaDolares(double valoremReais, double taxcambio)
        {
            return valoremReais / taxcambio;
        }
    }
}