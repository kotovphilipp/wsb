using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcje4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;


            increment(ref a);
            Console.WriteLine("Wartosc zmiennej x przed wywolaniem funkcji: {0}", a);

            Console.ReadKey();
        }


        static void increment(out int x)
        {
            x = 1;
            x += 10;
            Console.WriteLine("Wartosc zmiennej x przed wywolaniem funkcji: {0}", x);

        }
    }

}
