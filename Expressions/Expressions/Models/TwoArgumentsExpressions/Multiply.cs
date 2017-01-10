namespace Expressions.Models.TwoArgumentsExpressions
{
    public class Multiply : BinaryExpression
    {
        public Multiply(Expression leftSide, Expression rightSide) 
            : base(leftSide, rightSide)
        {}

        public override double Compute(double x)
        {
            return leftSide.Compute(x)*rightSide.Compute(x);
        }
    }
}