using System;

namespace _01.ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string reversed = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }

            Console.WriteLine(reversed);
        }
    }
}
