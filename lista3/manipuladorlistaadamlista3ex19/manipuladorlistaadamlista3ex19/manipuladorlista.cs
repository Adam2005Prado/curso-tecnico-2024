using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace manipuladorlistaadamlista3ex19
{
    public class manipuladorlista
    {
        public void removerelemento(List<int> lista, int numero)
        {
            lista.RemoveAll(item => item == numero);
        }
        public void removerelemento1(List<int> lista, int indice)
        {
            if (indice >= 0 && indice < lista.Count)
            {
                lista.RemoveAt(indice);
            }
        }
    }
}
