namespace Expressions.Models.OneArgumentExpressions
{
    public abstract class OneArgumentExpression : Expression
    {
        protected Expression subexpression;

        protected OneArgumentExpression(Expression subexpression)
        {
            this.subexpression = subexpression;
        }
    }
}