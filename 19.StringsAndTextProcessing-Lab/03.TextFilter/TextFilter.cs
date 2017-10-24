using System;

namespace _03.TextFilter
{
    class TextFilter
    {
        static void Main()
        {
            string[] bannedWords = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            for (int i = 0; i < bannedWords.Length; i++)
            {
                string currentBann = bannedWords[i];

                if (text.Contains(currentBann))
                {
                    text = text.Replace(currentBann, $"{new string('*', currentBann.Length)}");
                }
            }

            Console.WriteLine(text);
        }
    }
}
