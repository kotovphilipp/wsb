using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phil2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            Console.WriteLine("Wartosc zmiennej x przed wywolaniem funkcji: {0}", a);
            increment(ref a);
            Console.WriteLine("Wartosc zmiennej x w wywolaniem funkcji: {0}", a);


            Console.ReadKey();
        }

        static void increment (ref int x)
        {
            x += 10;
            Console.WriteLine("zmenna x wewnatrz funkcji: {0}", x);
        }
    }
}
