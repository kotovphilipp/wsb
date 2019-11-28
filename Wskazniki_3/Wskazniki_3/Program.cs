using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wskazniki_3
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
            int[] tab = { 10, 20, 30, 40, 50 };

            fixed (int* x = tab)
                
                for (int i = 0; i< 5;i++)
                {
                    Console.Write("Adres tab[{0}] = {1}", i,(int)(x+i));
                    Console.WriteLine(", wartosc: {0}", *(x+i));
                    

                }





            Console.ReadKey();
        }
    }
}
