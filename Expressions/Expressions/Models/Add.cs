using System;
using System.Collections.Generic;
using System.Linq;

namespace Expressions.Models
{
    public class Add : Expression
    {
        private readonly List<Expression> subexpressions = new List<Expression>();

        public Add(Expression fst, Expression snd, params Expression[] input)
        {
            subexpressions.Add(fst);
            subexpressions.Add(snd);
            foreach (var number in input)
            {
                subexpressions.Add(number);
            }
        }

        public override double Compute(double x)
        {
            return subexpressions.Select(e => e.Compute(x)).Sum();
        }
    }
}