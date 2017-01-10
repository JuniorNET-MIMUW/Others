using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyrażenia.Wyrażenia.WyrażeniaDwuargumentowe
{
    abstract class WyrażenieDwuargumentowe : Wyrażenie
    {
        protected Wyrażenie lewaStrona;
        protected Wyrażenie prawaStrona;

        protected WyrażenieDwuargumentowe(Wyrażenie lewaStrona, Wyrażenie prawaStrona)
        {
            this.lewaStrona = lewaStrona;
            this.prawaStrona = prawaStrona;
        }
    }
}
