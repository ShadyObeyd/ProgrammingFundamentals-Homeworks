using System;

namespace _03.UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string result = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                result += "\\u" + ((int)input[i]).ToString("x4");
            }

            Console.WriteLine(result);
        }
    }
}
