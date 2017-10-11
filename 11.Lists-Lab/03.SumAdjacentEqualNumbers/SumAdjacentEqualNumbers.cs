using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main()
        {
            List<decimal> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToList();

            bool hasEquals = true;

            while (hasEquals)
            {
                hasEquals = false;
                decimal sum = 0;
                int index = 0;

                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i - 1] == numbers[i])
                    {
                        index = i - 1;
                        sum = numbers[i - 1] + numbers[i];
                        hasEquals = true;
                        break;
                    }
                }
                if (hasEquals)
                {
                    numbers.RemoveRange(index, 2);
                    numbers.Insert(index, sum);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
