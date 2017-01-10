namespace Expressions.Models.TwoArgumentsExpressions
{
    public class Add : BinaryExpression
    {
        public Add(Expression leftSide, Expression rightSide) 
            : base(leftSide, rightSide)
        {}

        public override double Compute(double x)
        {
            return leftSide.Compute(x) + rightSide.Compute(x);
        }
    }
}