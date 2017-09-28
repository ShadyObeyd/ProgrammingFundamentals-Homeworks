using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.NumberChecker
{
    class NumberChecker
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int num;

            if (int.TryParse(input, out num))
            {
                Console.WriteLine("It is a number.");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
