using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main()
        {
            SortedDictionary<double, int> data = new SortedDictionary<double, int>();

            List<double> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            foreach (double num in numbers)
            {
                if (!data.ContainsKey(num))
                {
                    data.Add(num, 0);
                }
                data[num]++;
            }

            foreach (KeyValuePair<double, int> nums in data)
            {
                double num = nums.Key;
                int count = nums.Value;

                Console.WriteLine($"{num} -> {count}");
            }
        }
    }
}
