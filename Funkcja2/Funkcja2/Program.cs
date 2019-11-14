using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcja2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(checkEven(8));
            Console.WriteLine(checkEven(7));
            /*napisz funkcje wyswetlajaca sume cyfr liczby calkowitej
             * np.  123=>6
             *      2362 => 13
             */
            int x = 1235;
            Console.WriteLine("Suma cyfr {1} wynosi : {0}",sum(x), x);

            Console.ReadKey();
        }

        static string checkEven(int x)
        {
            if (x % 2 == 0)
            {
                return "Liczba Parzysta";

            }
            else
            {
                return "Liczba neparzysta";
            }
            
            
         
            

            
        }
        
        static int sum(int x)
        {
            int sum = 0;

            do
            {
                sum = sum + x % 10;
                x /= 10;
            } while (x != 0);

            return sum;
        }
    }
}
