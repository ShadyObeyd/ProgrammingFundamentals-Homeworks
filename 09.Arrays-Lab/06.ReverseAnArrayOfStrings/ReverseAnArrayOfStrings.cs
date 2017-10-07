using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReverseAnArrayOfStrings
{
    class ReverseAnArrayOfStrings
    {
        static void Main()
        {
            string[] strings = Console.ReadLine().Split(' ');

            Console.WriteLine(string.Join(" ", strings.Reverse().ToArray()));
        }
    }
}
