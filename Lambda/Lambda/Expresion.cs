using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Expresion
    {
        static void Main(string[] args)
        {
            Func<string, int, int, decimal> H;
            H = (msg, a, b) => Add(msg, a, b);
            H("Mensaje",5, 5);

            Console.ReadKey();
        }

        static decimal Add(string msg, int a, int b)
        {
            Console.WriteLine($"{msg} {a} {b}");
            return a + b;
        }
    }
}
