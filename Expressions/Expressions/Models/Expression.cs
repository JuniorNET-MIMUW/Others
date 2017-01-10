using System;
using Expressions.Models.TwoArgumentsExpressions;

namespace Expressions.Models
{
    public abstract class Expression
    {
        public abstract double Compute(double x);

        public static Expression operator +(Expression leftSide, Expression rightSide)
        {
            return new Add(leftSide, rightSide);
        }

        public static Expression operator *(Expression leftSide, Expression rightSide)
        {
            return new Multiply(leftSide, rightSide);
        }
    }
}