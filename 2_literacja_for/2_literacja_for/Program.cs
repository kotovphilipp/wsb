using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_literacja_for
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i;
            //wyswet liczby clkowite z przedziala <1,10>
            for (int i = 1;i <= 10 ; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //wyswiet liczby parzyste z przedzialu <5,20> while porzadku malejącym
            for (int b = 20; b >=5; b--)
            {
                if (b % 2 == 0)
                {
                    Console.Write("{0} ", b);
                }
            }
            /*
             *wyswietl na ekranie
             *  
             * *
             * **
             * ***
             * ****
             * *****
             *
             * Wysokosc choinki uzytkownik podaja z klawiatury
             */
            Console.WriteLine("Podaj dlugosc choinki: ");
           
            
           
            string x = Console.ReadLine();
            int x1;
            Console.WriteLine();
            if (int.TryParse(x, out x1) == true)
            {

                for (int i = 1; i <= x1; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.WriteLine("*");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
