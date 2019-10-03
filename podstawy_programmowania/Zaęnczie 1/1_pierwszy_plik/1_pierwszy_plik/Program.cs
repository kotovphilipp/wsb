using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_pierwszy_plik
{
    class Program
    {
        static void Main(string[] args)
        { 

         Console.WriteLine("WSB");
            Console.WriteLine("Nowa Linia");

            Console.Write("Proszę podaj swoje imię: ");
            //typ string
            string name = Console.ReadLine();
            Console.WriteLine("Masz na imię: ");
            Console.WriteLine(name);

            //typ całkowity integer
            int age = 20;
            Console.WriteLine(age);

            uint number = 10;

            //typ float
            float z = 14.55F;
            //+ konkatenacja
            Console.WriteLine("Zmienna z wnosi: " + z);

            Console.WriteLine("Program obliczający pole prostokąta:");

            Console.WriteLine("Podaj wartość a: ");
            float x = float.Parse(Console.ReadLine());


            Console.WriteLine("Podaj wartość b: ");
            float y = float.Parse(Console.ReadLine());

            
            float i = x * y;

        
            Console.WriteLine("Pole prostokata jest " + i);


            int j, k = 10, l;

            //int zmienna = 10;
            int zmienna = new int();



         Console.ReadKey();
        }
    }
}
