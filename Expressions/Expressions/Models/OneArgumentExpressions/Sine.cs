using System;

namespace Expressions.Models.OneArgumentExpressions
{
    public class Sine : UnaryExpression
    { 
        private Sine(Expression subexpression) : base(subexpression)
        {}

        public static Expression GetSine(Expression subexpression)
        {
            if(subexpression is Constant)
                return new Constant(Math.Sin(subexpression.Compute(0)));

            var sine = new Sine(subexpression);
            return sine;
        }

        public static Expression GetSine(double value)
        {
            return new Constant(Math.Sin(value));
        }

        public override double Compute(double x)
        {
            return Math.Sin(subexpression.Compute(x));
        }
    }
}