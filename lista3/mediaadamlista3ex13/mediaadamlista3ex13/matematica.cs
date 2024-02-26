using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediaadamlista3ex13
{
    public class matematica
    {
        public int Calcular( int[] numeros)
        {
            int soma = 0;
            foreach (int numero in numeros)
            {
                soma += numero;
            }
            return soma;
        }
        public double calcular(params int[] numeros) 
        {
            if (numeros.Length == 0)
            {
                return 0.0;
            }
            int soma = Calcular(numeros);
            return (double)soma / numeros.Length;
        }
    }

    }

