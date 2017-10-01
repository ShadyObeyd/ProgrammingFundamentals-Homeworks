using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main()
        {
            string hello = "Hello";
            string world = "World";
            object concatinatedStrings = hello + " " + world;
            string result = (string)concatinatedStrings;

            Console.WriteLine(result);
        }
    }
}
