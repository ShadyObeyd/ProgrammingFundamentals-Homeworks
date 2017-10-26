using System;
using System.Linq;

namespace _05.MagicExchangeableWords
{
    class MagicExchangeableWords
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            char[] firstWord = input[0].ToCharArray().Distinct().ToArray();
            char[] secondWord = input[1].ToCharArray().Distinct().ToArray();

            if (firstWord.Length == secondWord.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
