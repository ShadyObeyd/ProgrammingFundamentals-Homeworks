using System;

namespace _02.CountSubstringOccurences
{
    class CountSubstringOccurences
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();

            int count = 0;
            int index = -1;

            while (true)
            {
                index = input.IndexOf(pattern, index + 1);

                if (index == -1)
                {
                    break;
                }
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
