using System;
using System.Linq;

namespace _04.CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string firstString = input[0];
            string secondString = input[1];

            int sum = 0;

            if (firstString.Length > secondString.Length)
            {
                sum = CalculateChars(secondString, firstString);
            }
            else if (secondString.Length > firstString.Length)
            {
                sum = CalculateChars(firstString, secondString);
            }
            else
            {
                for (int i = 0; i < firstString.Length; i++)
                {
                    sum += firstString[i] * secondString[i];
                }
            }

            Console.WriteLine(sum);
        }

        static int CalculateChars(string shortStr, string longStr)
        {
            int sum = 0;

            for (int i = 0; i < shortStr.Length; i++)
            {
                sum += shortStr[i] * longStr[i];
            }

            char[] arr = longStr.ToCharArray().Skip(shortStr.Length).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }
    }
}
