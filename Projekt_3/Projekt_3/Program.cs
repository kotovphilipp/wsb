using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.ReadKey();
            //napisz program który za pomocą instrukcji do,,,whie dla danych wartosci zmieniających się w przediale od 0 do 25 wartosc funkcji y = 4x
            int y = 0, x = 0;
            do
            {


                y = 4 * x;
                Console.WriteLine("x = {0}\ti = {1}", x, y);
                x++;
            } while (x <= 15);

            //napisz program znajdujący siępowyżej za pomocą pętli while
            Console.WriteLine();
            x = 0;
            y = 0;

            while(x <=15)
            {
                y = 4 * x;
                Console.WriteLine("x = {0}\ti = {1}", x, y);
                x++;



            }
            Console.WriteLine();

            /* Napisz program, ktory za pomoca instrukcji while dla danych wartosci x zmieniajacych sie w przedziale od 1 do 50
             * oblcizy ich sumę
             * */
            Console.WriteLine();
            int suma;
            x = 1;
            suma = 0;
            do
            {
                suma += x;
                x++;

            } while (x <= 50);
                Console.WriteLine("suma = {0}",suma);


            

            Console.WriteLine();


            /*Napisz program, ktory za pomoca petli for sumije liczby nieparzyste z przedzialu 1 do 10
             * */
            /*x = 1;
            suma = 0;
            do
            {
                suma += x;
            Console.WriteLine("x = {0} , suma = {1}", x, suma);
                x += 2;
            } while (x <= 10);
            */


            suma = 0;
            for(int i = 1; i<= 10; i++)
            {
                if (i % 2 != 0)
                suma += i;

                Console.WriteLine("Suma wynosi: {0}", suma);
            }
            Console.WriteLine();



            int n = 10, row, col;
            row = 1;
            do
            {
                col = 1;
                do
                {
                    Console.Write(row * col + "\t");
                    col++;

                }
                while (col <= n);
                row++;
                Console.WriteLine();

            } while (row <= n);


            /*Napisz program ktory wyswetli duze litery alfabetu od A do Z i od Z do A z wykorzystaniem petli for
             * */


            char znak = 'A';
            for (; znak <= 'Z'; znak++)
                if (znak < 'Z')
                    Console.Write(znak + ", ");
            else
                    Console.Write(znak + ". ");
            Console.WriteLine();
            znak = 'Z';
            for(; znak >= 'A'; znak--)
            {
                if (znak > 'A')
                    Console.Write(znak + ", ");
                else
                    Console.Write(znak + ". ");
            }
            Console.WriteLine();

            //Continue
            int j = 1;
            for (;  j<=10; j++)
            {
                if (j == 3 || j == 6 || j == 7) 
                     continue;
                else
                Console.Write("{0} ", j);
            }
            Console.WriteLine();

            //break
            j = 2;
            for (; j<=10; j++)
            {
                if (j == 3 || j == 6 || j == 7)
                    break;
                else
                    Console.Write("{0} ", j);
            }


            
            Console.ReadKey();
        }
    }
}
