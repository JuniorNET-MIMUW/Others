using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyrażenia.Wyrażenia.WyrażeniaDwuargumentowe
{
    class Mnożenie : WyrażenieDwuargumentowe
    {
        public Mnożenie(Wyrażenie lewaStrona, Wyrażenie prawaStrona) : base(lewaStrona, prawaStrona)
        {}

        public override double Oblicz(double x)
        {
            return lewaStrona.Oblicz(x)*prawaStrona.Oblicz(x);
        }
    }
}
