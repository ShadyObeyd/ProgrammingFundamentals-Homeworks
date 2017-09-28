using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.GameOfNumbers
{
    class GameOfNumbers
    {
        static void Main()
        {
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int first = 0;
            int second = 0;
            int comboCntr = 0;

            for (int i = min; i <= max; i++)
            {
                for (int j = min; j <= max; j++)
                {
                    if (i + j == magicNum)
                    {
                        first = i;
                        second = j;
                    }
                    comboCntr++;
                }
            }

            if (first + second == magicNum)
            {
                Console.WriteLine($"Number found! {first} + {second} = {first + second}");
            }
            else
            {
                Console.WriteLine($"{comboCntr} combinations - neither equals {magicNum}");
            }
        }
    }
}
