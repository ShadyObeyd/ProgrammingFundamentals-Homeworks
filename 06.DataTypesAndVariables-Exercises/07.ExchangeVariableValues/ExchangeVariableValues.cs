using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main()
        {
            sbyte a = 5;
            sbyte b = 10;

            sbyte tempratya = b;
            sbyte temporaryb = a;

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine("After:");
            Console.WriteLine($"a = {tempratya}");
            Console.WriteLine($"b = {temporaryb}");
        }
    }
}
