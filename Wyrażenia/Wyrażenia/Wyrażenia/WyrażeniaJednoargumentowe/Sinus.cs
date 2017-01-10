using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyrażenia.Wyrażenia.WyrażeniaJednoargumentowe
{
    class Sinus : WyrażenieJednoargumentowe
    {
        public Sinus(Wyrażenie podwyrażenie) : base(podwyrażenie)
        { }

        public override double Oblicz(double x)
        {
            return Math.Sin(podwyrażenie.Oblicz(x));
        }
    }
}
