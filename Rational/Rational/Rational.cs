using System;

namespace Rational
{
    public struct Rational : IComparable<Rational>
    {
        public int Numerator { get; }
        public int Denominator { get; }
        public int Sign { get; }

        public Rational(int p, int q = 1)
        {
            Numerator = Math.Abs(p);
            if (p == 0)
            {
                Denominator = 1;
                Sign = 0;
                return;
            }
            if(q == 0) throw new DivideByZeroException();
            Denominator = Math.Abs(q);
            int gcd = GCD(Numerator, Denominator);
            Numerator /= gcd;
            Denominator /= gcd;
            Sign = Math.Sign(Numerator*Denominator);
        }

        public Rational Zero => new Rational(0);
        public Rational One => new Rational(1);

        public Rational Add(Rational another) // a/b + c/d = ad/bd + cb/bd = (ad + bc)/bd
        {
            int numerator = Sign*Numerator*another.Denominator + 
                another.Sign*Denominator*another.Numerator;
            return new Rational(numerator, Denominator*another.Denominator);
        }

        public Rational Substract(Rational another) => Add(another.Opposite());

        public Rational Multiply(Rational another)
        {
            int numerator = Sign*another.Sign*Numerator*another.Numerator;
            return new Rational(numerator, Denominator*another.Denominator);
        }

        public Rational Divide(Rational another) => Multiply(another.Inverse());

        public Rational Inverse() => new Rational(Sign*Denominator, Numerator);

        public Rational Opposite() => new Rational(-Sign*Numerator, Denominator);


        public int CompareTo(Rational other)
        {
            if (Sign != other.Sign) return Sign.CompareTo(other.Sign);
            int res = (Numerator*other.Denominator).CompareTo(Denominator*other.Numerator);
            switch (Sign)
            {
                case 0:
                    return 0;

                case 1:
                    return res;

                case -1:
                    return -res;

                default:
                    throw new ArithmeticException("Unreachable code");
            }
        }

        public override string ToString()
        {
            return Sign * Numerator + "/" + (Denominator == 1 ? "" : Denominator.ToString());
        }

        public static Rational operator +(Rational leftSide, Rational rightSide)
        {
            return leftSide.Add(rightSide);
        }

        public static Rational operator -(Rational leftSide, Rational rightSide)
        {
            return leftSide.Substract(rightSide);
        }

        public static Rational operator *(Rational leftSide, Rational rightSide)
        {
            return leftSide.Multiply(rightSide);
        }

        public static Rational operator /(Rational leftSide, Rational rightSide)
        {
            return leftSide.Divide(rightSide);
        }

        public static Rational operator -(Rational rational) => rational.Opposite();


        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                var c = a % b;           
                a = b;               
                b = c;               
            }
            return a;
        }
    }
}