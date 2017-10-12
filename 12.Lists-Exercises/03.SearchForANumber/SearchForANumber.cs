using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SearchForANumber
{
    class SearchForANumber
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] arr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int countOfNumsToTake = arr[0];
            int countOfNumsToDelete = arr[1];
            int numToSearchFor = arr[2];

            numbers =
                numbers
                .Take(countOfNumsToTake)
                .ToList();

            numbers.RemoveRange(0, countOfNumsToDelete);

            if (numbers.Contains(numToSearchFor))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }

        }
    }
}
