using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            if (input == "int")
            {
                int firstNum = int.Parse(first);
                int secondNum = int.Parse(second);

                int result = GetMaxInt(firstNum, secondNum);
                Console.WriteLine(result);
            }
            else if (input == "char")
            {
                char firstChar = char.Parse(first);
                char secondChar = char.Parse(second);

                char result = GetMaxChar(firstChar, secondChar);
                Console.WriteLine(result);
            }
            else
            {
                string result = GetMaxString(first, second);
                Console.WriteLine(result);
            }
        }

        private static int GetMaxInt(int firstNum, int secondNum)
        {
            if (firstNum >= secondNum)
            {
                return firstNum;
            }
            return secondNum;
        }

        private static char GetMaxChar(char firstChar, char secondChar)
        {
            if (firstChar >= secondChar)
            {
                return firstChar;
            }
            return secondChar;
        }

        private static string GetMaxString(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            return second;
        }
    }
}
