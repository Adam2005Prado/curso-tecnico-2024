using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circuloadamlista3ex5
{
    public class Circulo
    {
        private double _raio;

        public double Raio
        {
            get { return _raio; }
            set
            {
                if (value > 0)
                {
                    _raio = value;
                    MessageBox.Show($"O raio é {_raio}");
                }
                else
                {
                    MessageBox.Show("Erro! O raio tem que ser maior que zero!");
                }
            }
        }

        public double Diametro
        {
            get { return 2 * _raio; }
        }
    }
}
