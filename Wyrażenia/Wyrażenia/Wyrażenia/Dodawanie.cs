using System.Linq;

namespace Wyrażenia.Wyrażenia
{
    public class Dodawanie : Wyrażenie
    {
        private readonly Wyrażenie[] podwyrażenia;

        public Dodawanie(params Wyrażenie[] podwyrażenia)
        {
            this.podwyrażenia = podwyrażenia;
        }

        public override double Oblicz(double x)
        {
            var wyniki =
                from wyrażenia in podwyrażenia
                select wyrażenia.Oblicz(x);
            return wyniki.Sum();
        }
    }
}