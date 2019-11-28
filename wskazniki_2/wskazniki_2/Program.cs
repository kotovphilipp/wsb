﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wskazniki_2
{
    class Program
    {
        unsafe static void Swap(int* a, int* b)
        {
            int pom = *a;
            *a = *b;
            *b = pom;
        }

        unsafe static void Main(string[] args)
        {
            int x = 2;
            int y = 5;

            Console.WriteLine("Wartosci przed zamiany: x = {0}, y = {1}", x, y);
            Swap(&x, &y);
            Console.WriteLine("Wartosci po zamianie: x = {0}, y = {1}", x, y);


            int a = 100;
            int b = 200;

            int* a1 = &a;
            int* b1 = &b;


            Console.WriteLine("Wartosci przed zamiany: x = {0}, y = {1}", a, b);
            Swap(a1, b1);
            Console.WriteLine("Wartosci po zamianie: x = {0}, y = {1}", a, b);





            Console.ReadKey();
        }
    }
}
