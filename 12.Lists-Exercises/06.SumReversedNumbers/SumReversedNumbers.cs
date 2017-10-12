using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumReversedNumbers
{
    class SumReversedNumbers
    {
        static void Main()
        {
            List<string> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<int> result = new List<int>();

            foreach (string number in numbers)
            {
                int reversedNumber = ReverseNumber(number);
                result.Add(reversedNumber);
            }

            Console.WriteLine(result.Sum());
        }

        private static int ReverseNumber(string number)
        {
            char[] arr = number.ToArray();
            string reversed = string.Empty;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                reversed += arr[i]; 
            }
            return int.Parse(reversed);
        }
    }
}
