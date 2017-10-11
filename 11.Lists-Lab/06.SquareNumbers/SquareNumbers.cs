using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNum = numbers[i];

                if (Math.Sqrt(currentNum) == (int)Math.Sqrt(currentNum))
                {
                    result.Add(currentNum);
                }
            }

            result = result
                .OrderByDescending(n => n)
                .ToList();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
