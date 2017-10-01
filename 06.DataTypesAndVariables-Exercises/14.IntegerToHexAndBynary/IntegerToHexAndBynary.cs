using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegerToHexAndBynary
{
    class IntegerToHexAndBynary
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            string numToHex = number.ToString("X");

            Console.WriteLine(numToHex);

            string numToBynary = Convert.ToString(number, 2);

            Console.WriteLine(numToBynary);
        }
    }
}
