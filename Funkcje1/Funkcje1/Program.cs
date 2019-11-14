using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcje1
{
    class Program
    {
        static void Main(string[] args)
        {

            Show();
            Add(3, 5);
            Add(2, 3, 4);

            Console.WriteLine("funkcja z 4 argumentami: {0} ",Add(1, d:2));


            data("Janusz", age:22);

            Console.ReadKey();

        }

        static void Show()
        {
            Console.WriteLine("WSB");

        }

        static void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Wynik dodawania {1} i {2}: {0}", result, a, b);
           
        }

        static void Add(int a, int b, int c)
        {
            Console.WriteLine("Wynik = {0}", a + b + c);
        }


        static int Add(int a,  int d, int c = 10, int b = 5)
        {
            return a + b + c + d;
        }

        static void data(string name, string surname="Kotov", int age = 22)
        {
            Console.WriteLine("Imie: {0}, nazwisko: {1}, wiek: {2}", name, surname, age);
        }
    }


}
