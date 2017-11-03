using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CommandInterpreter
{
    class CommandInterpreter
    {
        static List<string> words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        static void Main()
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] commandTokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int startIndex = 0;
                int count = 0;

                switch (commandTokens[0])
                {
                    case "reverse":
                        startIndex = int.Parse(commandTokens[2]);
                        count = int.Parse(commandTokens[4]);
                        Reverse(startIndex, count);
                        break;
                    case "sort":
                        startIndex = int.Parse(commandTokens[2]);
                        count = int.Parse(commandTokens[4]);
                        SortList(startIndex, count);
                        break;
                    case "rollLeft":
                        count = int.Parse(commandTokens[1]);
                        RollLeft(count);
                        break;
                    case "rollRight":
                        count = int.Parse(commandTokens[1]);
                        RollRight(count);
                        break;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", words)}]");
        }

        private static void RollRight(int count)
        {
            if (count >= 0)
            {
                for (int i = 0; i < count % words.Count; i++)
                {
                    string last = words[words.Count - 1];

                    for (int j = words.Count - 1; j > 0; j--)
                    {
                        words[j] = words[j - 1];
                    }
                    words[0] = last;
                }
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");
            }
        }

        static void RollLeft(int count)
        {
            if (count >= 0)
            {
                for (int i = 0; i < count % words.Count; i++)
                {
                    string first = words[0];

                    for (int j = 0; j < words.Count - 1; j++)
                    {
                        words[j] = words[j + 1];
                    }
                    words[words.Count - 1] = first;
                }
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");
            }
        }

        private static void SortList(int startIndex, int count)
        {
            if (IsValid(startIndex, count))
            {
                List<string> temp = words.Skip(startIndex).Take(count).ToList();
                temp.Sort();

                words.RemoveRange(startIndex, count);
                words.InsertRange(startIndex, temp);
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");
            }
        }

        static void Reverse(int startIndex, int count)
        {
            if (IsValid(startIndex, count))
            {
                words.Reverse(startIndex, count);
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");
            }
        }

        static bool IsValid(int startIndex, int count)
        {
            bool isInRange = startIndex >= 0 && startIndex < words.Count;
            bool isValidParameters = count >= 0 && (startIndex + count) <= words.Count;

            if (isInRange && isValidParameters)
            {
                return true;
            }
            return false;
        }
    }
}
