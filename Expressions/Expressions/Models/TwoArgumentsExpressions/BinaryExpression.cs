namespace Expressions.Models.TwoArgumentsExpressions
{
    public abstract class BinaryExpression : Expression
    {
        protected Expression leftSide;
        protected Expression rightSide;

        protected BinaryExpression(Expression leftSide, Expression rightSide)
        {
            this.leftSide = leftSide;
            this.rightSide = rightSide;
        }
    }
}