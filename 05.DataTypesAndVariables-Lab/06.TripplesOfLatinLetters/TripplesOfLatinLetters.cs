﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TripplesOfLatinLetters
{
    class TripplesOfLatinLetters
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int l = 0; l < n; l++)
                    {
                        Console.WriteLine($"{(char)('a' + i)}{(char)('a' + j)}{(char)('a' + l)}");
                    }
                }
            }
        }
    }
}
