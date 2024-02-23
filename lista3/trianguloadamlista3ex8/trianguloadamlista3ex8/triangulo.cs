using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trianguloadamlista3ex8
{
    public class triangulo
    {
        public double ladoA { get; set; }
        public double ladoB { get; set; }
        public double ladoC { get; set; }

        public double perimetro
        {
            get { return ladoA + ladoB + ladoC; }
        }
    }
}