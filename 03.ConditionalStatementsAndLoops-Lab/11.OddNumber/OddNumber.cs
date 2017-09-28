using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.OddNumber
{
    class OddNumber
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            while (true)
            {
                if (Math.Abs(number) % 2 == 1)
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                    break;
                }
                Console.WriteLine("Please write an odd number.");
                number = int.Parse(Console.ReadLine());
            }
        }
    }
}
