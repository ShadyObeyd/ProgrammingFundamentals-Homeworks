using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FoldAndSum
{
    class FoldAndSum
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> firstHalf = numbers.Take(numbers.Count / 4).ToList();
            firstHalf.Reverse();

            List<int> middlePart = numbers.Skip(firstHalf.Count).Take(numbers.Count / 2).ToList();

            List<int> secondHalf = numbers.Skip(firstHalf.Count + numbers.Count / 2).ToList();
            secondHalf.Reverse();

            List<int> concatedLists = firstHalf.Concat(secondHalf).ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < middlePart.Count; i++)
            {
                result.Add(concatedLists[i] + middlePart[i]);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
