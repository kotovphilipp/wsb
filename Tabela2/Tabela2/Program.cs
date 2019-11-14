using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabela2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[2];
            tab[0] = 10;
            tab[1] = 5;
            Console.WriteLine("wartosci tablicy przed wywolaniem funkcji: {0} i {1}", tab[0], tab[1]);
            Tab1(tab);
            Console.WriteLine("wartosci tablicy po wywolaniu funkcji: {0} i {1}", tab[0], tab[1]);

            Console.ReadKey();

        }


        static void Tab1(int [] tab)
        {
            tab[0] = 100;
            tab[1] = 50;

            Console.WriteLine("wartosc wewnatrz funkcji: {0} i {1} ", tab[0], tab[1]);
        }
    }
}
