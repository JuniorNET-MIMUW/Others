namespace Expressions.Models
{
    public class Variable : Expression
    {
        public override double Compute(double x)
        {
            return x;
        }
    }
}