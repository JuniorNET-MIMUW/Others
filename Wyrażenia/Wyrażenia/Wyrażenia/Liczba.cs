using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyrażenia.Wyrażenia
{
    class Liczba : Wyrażenie
    {
        private readonly double wartość;

        public Liczba(double wartość)
        {
            this.wartość = wartość;
        }

        public override double Oblicz(double x)
        {
            return wartość;
        }
    }
}
