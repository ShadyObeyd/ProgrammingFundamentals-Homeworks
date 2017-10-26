using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _01.ConvertFromBase10ToBaseN
{
    class ConvertFromBase10ToBaseN
    {
        static void Main()
        {
            BigInteger[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(BigInteger.Parse)
                .ToArray();

            BigInteger baseN = input[0];
            BigInteger number = input[1];

            BigInteger remainder = 0;

            List<BigInteger> result = new List<BigInteger>();

            while (number != 0)
            {
                remainder = number % baseN;

                number /= baseN;

                result.Add(remainder);
            }

            result.Reverse();

            Console.WriteLine(string.Join("", result));
        }
    }
}
