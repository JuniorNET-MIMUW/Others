using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyrażenia.Wyrażenia.WyrażeniaJednoargumentowe
{
    abstract class WyrażenieJednoargumentowe : Wyrażenie
    {
        protected Wyrażenie podwyrażenie;

        protected WyrażenieJednoargumentowe(Wyrażenie podwyrażenie)
        {
            this.podwyrażenie = podwyrażenie;
        }
    }
}
