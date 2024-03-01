using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadorageometricaadamlista3ex15
{
    public class calculadorageometrica
    {
       static public double calculoarea(double largura,double altura)
        {
        return largura * altura;
        }
      static  public double calculoarea(double raio)
            {
            return Math.PI*Math.Pow(raio, 2);
        }
      static  public double calculoarea1(double basetriangulo,double alturatriangulo)
        {
            double res = 0.5 * basetriangulo * alturatriangulo;
            return res ;
        }
    }
}
