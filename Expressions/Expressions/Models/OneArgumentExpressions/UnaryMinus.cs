namespace Expressions.Models.OneArgumentExpressions
{
    public class UnaryMinus : OneArgumentExpression
    {
        public UnaryMinus(Expression subexpression) : base(subexpression)
        {}

        public override double Compute(double x)
        {
            return -subexpression.Compute(x);
        }
    }
}