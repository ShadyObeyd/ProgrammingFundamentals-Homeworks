using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CondenseArrayToNumber
{
    class CondenseArrayToNumber
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            while (numbers.Length > 1)
            {
                int[] condenced = new int[numbers.Length - 1];

                for (int i = 0; i < condenced.Length; i++)
                {
                    condenced[i] = numbers[i] + numbers[i + 1];
                }
                numbers = condenced;

            }
            Console.WriteLine(numbers[0]);
        }
    }
}
