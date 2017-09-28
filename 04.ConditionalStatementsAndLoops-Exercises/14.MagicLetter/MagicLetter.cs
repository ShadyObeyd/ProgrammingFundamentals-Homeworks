using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.MagicLetter
{
    class MagicLetter
    {
        static void Main()
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char forbidden = char.Parse(Console.ReadLine());

            for (int i = first; i <= second; i++)
            {
                for (int j = first; j <= second; j++)
                {
                    for (int l = first;  l <= second;  l++)
                    {
                        if (i != forbidden && j != forbidden && l != forbidden)
                        {
                            Console.Write($"{(char)i}{(char)j}{(char)l} ");
                        }
                    }
                }
            }
        }
    }
}
