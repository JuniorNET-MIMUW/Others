using Wyrażenia.Wyrażenia.WyrażeniaDwuargumentowe;

namespace Wyrażenia.Wyrażenia
{
    public abstract class Wyrażenie
    {
        public abstract double Oblicz(double x);

        public static Wyrażenie operator +(Wyrażenie leweWyrażenie, Wyrażenie praweWyrażenie)
        {
            return new Dodawanie(leweWyrażenie, praweWyrażenie);
        }

        public static Wyrażenie operator *(Wyrażenie leweWyrażenie, Wyrażenie praweWyrażenie)
        {
            return new Mnożenie(leweWyrażenie, praweWyrażenie);
        }
    }
}