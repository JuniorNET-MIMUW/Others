namespace Expressions.Models
{
    public class Constant : Expression
    {
        public double Value { get; }

        public Constant(double value)
        {
            Value = value;
        }

        public override double Compute(double x)
        {
            return Value;
        }

        public static implicit operator Constant(double value)
        {
            return new Constant(value);
        }
    }
}