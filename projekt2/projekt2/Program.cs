using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt2
{
    class Program
    {
        static void Main(string[] args)
        {
            //tablice prosokąte

            int[,] tab = new int[,]
            {
                {0, 1, 2},
                {3, 4, 5},
                {6, 7, 8},
                
            };

            //Console.WriteLine(tab[2, 2]);

            /* for (int i = 0; i < tab.GetLength(0); i++)
            {
                //wiersze
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    
                    Console.Write("{0}\t",tab[i, j]);

                }
                Console.WriteLine();
            }
            /* utworz tablice dwumiarowa 3X3 i*3+j
             *
             * 0 1 2
             * 3 4 5 
             * 6 7 8
             */

            int[,] numbers = new int[3, 3];

            //Console.WriteLine(numbers.GetLength(0));

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = i * 3 +j;
                    Console.Write("{0}\t", tab[i, j]);


                }
            }


            //foreach

            // deklaracja dwuwymjarowej tablicy nieregulare
            string[][] country = new string[4][];

            Console.WriteLine("\nROzmiar tablicy nieregularny{0}", country.Length);

            int[][] number = new int[3][]
            {
                new int[] {1},
                new int[] {2, 3, 4, 5},
                new int[] {6, 7}
            };

            for (int i = 0; i < number.GetLength(0); i++)
            {
                for (int j = 0; j < number[i].Length; j++)
                {
                    Console.WriteLine("number[{0}] [{1}] = {2}", i, j, number[i][j]);
                }
            }
            
       
                Console.WriteLine("\n");



            Console.ReadKey();
        }
    }
}
