using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wskaznik_1
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
            char* x;
            char letter = 'a';
            x = &letter;

            Console.WriteLine("Znak: {0}", letter); //wartosc zmienne
            //Console.WriteLine("Adres w pamieci: {0}", *x); //wartosc zmienne
            Console.WriteLine("Adres w pamieci: {0}",(int)x);


            double number;
            double* numberAddress;

            number = 10;
            numberAddress = &number;

            Console.WriteLine("Liczba wynosi: {0}", *numberAddress);
            Console.WriteLine("Adres wynosi zmiennej: {0}", (int)numberAddress);
            Console.WriteLine("Liczba wynosi: {0}", numberAddress->ToString());




            Console.ReadKey();
        
        
        }
    }
}
