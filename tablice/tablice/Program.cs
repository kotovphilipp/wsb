using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            //napisz program ktory w 10 elementowej tablicy jednowymiarowej o nazwie tab umiezszca liczby z przedzialu od 1 do 10

            int n = 10, i;

            //deklaracja tablicy o nazwie tab typu calkowitego o rozmiare od 1 do 10

            int[] tab = new int[n];

            for (i = 0; i < tab.Length; i++)
            {
                tab[i] = i;
            }
            //wyswietlenie zawartosci tablicy

            for(i =0; i<tab.Length; i++)
            {
                Console.Write("{0} ", tab[i]);
            }


            //napisz program ktory w 5 elementowej tablicy jednowymiarowej o nazwie colors kotorow podanie s klaviatury przez uzytkownika 
            //wyswietl kolory w formacie:
            //Kolor1: red
            //Kolor2: blue
            //...
            //kolor5 yellow


            string[] colors = new string[5];
            string color;

            for (i = 0; i < colors.Length; i++)
            {
                Console.Write("Podaj kolor:");
                color = Console.ReadLine();
                colors[i] = color;

            }

            Console.Clear();

            Console.WriteLine("kolory: ");
            int x = 0, count;
            while(x < colors.Length)
            {
                count = x + 1;
                Console.WriteLine(" Kolor {0}: {1}", count, colors[x]);
                x++;
            }


            Console.ReadKey();

        }
    }
}
