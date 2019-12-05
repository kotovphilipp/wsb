using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Text;

namespace Zaecie_05
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo wsbDir = new DirectoryInfo(".");

            DirectoryInfo studentDir = new DirectoryInfo("C:\\Users\\Student\\Desktop");
            //DirectoryInfo studentDir = new DirectoryInfo("C:\\Users\\Student");

            Console.WriteLine(studentDir.FullName);
            Console.WriteLine(studentDir.Name);
            Console.WriteLine(studentDir.Parent);
            Console.WriteLine(studentDir.Attributes);
            Console.WriteLine(studentDir.CreationTime);

            string[] customers =
            {
                "Anna Nowak",
                "Janusz Kowalski",
                "Tomasz Nowak"
            };

            //Directory.Delete(@"C\Users\Student\C#Files");

            string path = @"C:\Users\Student\C#Files";
            try
            {
                if (Directory.Exists(path))
                {
                    Console.WriteLine();
                }
                else
                {
                    Directory.CreateDirectory("\\Users\\Student\\C#Files");

                    string textFilePath = @"C\Users\Student\C#Files\testFile.txt";
                    File.WriteAllLines(textFilePath, customers);

                    Console.WriteLine("Katalog zostal otwtorozny: {0}", Directory.GetCreationTime(path));
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.ToString());
            }

            if (Directory.Exists(path))
            {
                Console.WriteLine("/nCzy checs usumac catalogue z pliakmi? 1- true, o-false");
                string delete = Console.ReadLine();

                if (delete == "1")
                {
                    Directory.Delete(path, true);
                }

                if (Directory.Exists(path))
                {
                    Console.WriteLine("nie umesc katalogue");
                }
            }
        
            Console.ReadKey();
        }
    }
}
