using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using Second_name;
using Outer.Middle.Inner;

namespace Philipp._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("WSB");

            First_name.namespace_1 obj1 = new First_name.namespace_1();
            obj1.Show();
            namespace_2 obj2 = new namespace_2();
            obj2.Show();

            //Outer.Middle.Inner.Prog ob = new Outer.Middle.Inner.Prog();
            Prog ob = new Prog();
            Console.WriteLine("Rezultat dodawania: {0}", ob.Add(3, 5));
            
            Console.ReadKey();
        }
    }
}
namespace First_name
{
    class namespace_1
    {
        public void Show()
        {
            Console.WriteLine("pierwsa przestrzen nazw");
        }
    }
}
namespace Second_name
{
    class namespace_2
    {
        public void Show()
        {
            Console.WriteLine("druga przestrzen nazw");
        }
    }
}
namespace Outer
{
    namespace Middle
    {
        namespace Inner
        {
            class Prog
            {
                public int x, y;

                public int Add(int x, int y)
                {
                    return x + y;
                }
            }
        }
    }
}