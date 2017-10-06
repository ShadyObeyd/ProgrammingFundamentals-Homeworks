using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());
        bool hasMatch = false;


        for (int i = 0; i < text.Length; i++)
        {
            char currentLetter = text[i];

            if (currentLetter == 'p')
            {
                hasMatch = true;

                string matchedString = string.Empty;
                if (i + jump + 1 <= text.Length)
                {
                    matchedString = text.Substring(i, jump + 1);
                }
                else
                {
                    matchedString = text.Substring(i);
                }

                Console.WriteLine(matchedString);

                i += jump;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}
