using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expressions.Models;
using Expressions.Models.OneArgumentExpressions;
using Expressions.Models.TwoArgumentsExpressions;

namespace Expressions
{
    class Program
    {
        static void Main()
        {
            Constant e = 2.6;
            Expression ee = Sine.GetSine(2.6);
            Expression sum = new Constant(5) + new Variable();
            Expression suma = new Models.Add(e, ee);
        }
    }
}
