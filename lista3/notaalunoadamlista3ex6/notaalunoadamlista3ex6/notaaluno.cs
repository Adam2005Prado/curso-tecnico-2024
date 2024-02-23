using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notaalunoadamlista3ex6
{
    public class Notaaluno
    {
        public string Nome { get; set; }
        public double[] Notas { get; set; }

        public double Media
        {
            get
            {
                if (Notas != null && Notas.Length > 0)
                {
                    return Notas.Average();
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
