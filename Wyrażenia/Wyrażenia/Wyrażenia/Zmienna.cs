using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyrażenia.Wyrażenia
{
    class Zmienna : Wyrażenie
    {
        public override double Oblicz(double x)
        {
            return x;
        }
    }
}
