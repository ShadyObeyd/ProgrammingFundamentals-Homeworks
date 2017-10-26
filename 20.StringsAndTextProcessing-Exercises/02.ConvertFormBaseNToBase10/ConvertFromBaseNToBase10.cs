using System;
using System.Linq;
using System.Numerics;

namespace _02.ConvertFormBaseNToBase10
{
    class ConvertFromBaseNToBase10
    {
        static void Main()
        {
            BigInteger[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(BigInteger.Parse)
                .ToArray();

            BigInteger baseN = input[0];
            BigInteger number = input[1];

            string num = number.ToString();

            BigInteger power = 1;
            BigInteger result = 0;

            for (int i = num.Length - 1; i >= 0; i--)
            {
                result += power * (num[i] - '0');
                power *= baseN;
            }
            Console.WriteLine(result);
        }
    }
}
