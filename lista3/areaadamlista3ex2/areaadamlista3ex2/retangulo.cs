using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaadamlista3ex2
{
    public class retangulo
    {
        public double largura {  get; set; }
        public double altura { get; set; }
        public double area
        {
            get
            {
                return largura * altura;
            }
        }
            public void Areacalculo()
        {
            MessageBox.Show($"Área do retângulo: {area}", "Área do Retângulo");

        }
        }
    }

