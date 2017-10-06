using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HelloName
{
    class HelloName
    {
        static void Main()
        {
            string name = Console.ReadLine();

            PrintUserName(name);
        }

        private static void PrintUserName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
