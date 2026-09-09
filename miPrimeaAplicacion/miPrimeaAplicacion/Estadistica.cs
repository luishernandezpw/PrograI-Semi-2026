using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miPrimeaAplicacion
{
    internal class Estadistica
    {
        public double media(double[] serie)
        {
            double suma = 0;
            for (int i = 0; i < serie.Length; i++)
            {
                suma += serie[i];
            }
            double media = suma / serie.Length;
            return media;
        }
        public double varianza(double[] serie, double media)
        {
            return serie.Average(n => Math.Pow(n - media, 2));
        }
        public double desviacionTipica(double[] serie, double media)
        {
            return Math.Sqrt(varianza(serie, media));
        }
        public double armonica(double[] serie)
        {
            int n = serie.Length;
            return n / serie.Sum(x => 1 / x);
        }
    }
}
