using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Bramki.Bramki;

namespace Bramki
{
    class Program
    {
        static void Main()
        {
            var wejście1 = new Wejście();
            var wejście2 = new Wejście();
            var and1 = new And(wejście1, wejście2);
            var or = new Or(wejście1, wejście2);
            var not = new Not(and1);
            var and2 = new And(not, or);
            Console.WriteLine(and2.Wartość);
            wejście2.Wartość = true;
            Console.WriteLine(and2.Wartość);
            wejście2.Wartość = true;
            Console.WriteLine(and2.Wartość);
            wejście1.Wartość = false;
            Console.WriteLine(and2.Wartość);
            Console.ReadKey();
        }
    }
}
