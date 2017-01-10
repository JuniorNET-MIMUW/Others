using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wyrażenia.Wyrażenia;

namespace Wyrażenia
{
    class Program
    {
        static void Main(string[] args)
        {
            Wyrażenie zmienna = new Zmienna();
            Wyrażenie liczba = new Liczba(42);
            Wyrażenie suma = zmienna + liczba;
        }
    }
}
