using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CountNumbers
{
    class CountNumbers
    {
        static void Main()
        {
            Dictionary<int, int> data = new Dictionary<int, int>();

            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNum = numbers[i];

                if (!data.ContainsKey(currentNum))
                {
                    data.Add(currentNum, 0);
                }
                data[currentNum]++;
            }

            foreach (KeyValuePair<int, int> numbersAndCount in data.OrderBy(k => k.Key))
            {
                int number = numbersAndCount.Key;
                int count = numbersAndCount.Value;

                Console.WriteLine($"{number} -> {count}");
            }
        }
    }
}
