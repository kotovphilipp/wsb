using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - pole kwadratu\n2 - pole kola");
           
            
            Console.Write("Wyberz Wartosc: ");
            string x, a;
            double a1, pole;
            x = Console.ReadLine();
         
            switch (x)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Podaj bok kwadratu ");
                    a = Console.ReadLine();
                    if (double.TryParse(a, out a1) == true)
                    {
                        pole = a1 * a1;
                        Console.WriteLine("Pole kwardatu o boku: {0} wynosi: {1:##.##}", a1, pole);
                    }
                    else
                    {
                        Console.WriteLine("Podales bledne dane!");
                    }
                    break;
                  
                case "2":
                    Console.Clear();
                    Console.WriteLine("Podaj radius ");
                    a = Console.ReadLine();
                    if (double.TryParse(a, out a1) == true)
                    {
                        pole = 2 * 3.14 * a1;
                        Console.WriteLine("Pole kola o radius: {0} wynosi {1:##.##}", a1, pole);

                    }
                    else
                    {
                        Console.WriteLine("Podales bledne dane!");
                    }
                  
                    break;
                default:
                    Console.WriteLine("Podales bledne danhy!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
