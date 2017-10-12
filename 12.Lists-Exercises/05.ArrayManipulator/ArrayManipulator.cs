using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine().ToLower();

            while (command != "print")
            {
                string[] tokens = command.Split(' ');

                int index = 0;
                int element = 0;
                switch (tokens[0])
                {
                    case "add":
                        index = int.Parse(tokens[1]);
                        element = int.Parse(tokens[2]);
                        numbers.Insert(index, element);
                        break;

                    case "addmany":
                        index = int.Parse(tokens[1]);
                        AddMany(index, element, tokens, numbers);
                        break;

                    case "contains":
                        element = int.Parse(tokens[1]);
                        Console.WriteLine(numbers.IndexOf(element));
                        break;

                    case "remove":
                        index = int.Parse(tokens[1]);
                        numbers.RemoveAt(index);
                        break;

                    case "shift":
                        int rotations = int.Parse(tokens[1]);
                        RotateLeft(rotations, numbers);
                        break;

                    case "sumpairs":
                        SumPairs(numbers, index);
                        break;
                }

                command = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        private static void SumPairs(List<int> numbers, int index)
        {
            index = 0;
            int sum = 0;

            for (int i = 1; i < numbers.Count; i++)
            {
                index = i - 1;
                sum = numbers[i - 1] + numbers[i];

                numbers.RemoveRange(index, 2);
                numbers.Insert(index, sum);
            }
        }

        private static void RotateLeft(int rotations, List<int> numbers)
        {
            for (int i = 0; i < rotations; i++)
            {
                int first = numbers[0];

                for (int j = 0; j < numbers.Count - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }
                numbers[numbers.Count - 1] = first;
            }
        }

        private static void AddMany(int index, int element, string[] tokens, List<int> numbers)
        {
            List<int> tokensToAdd = new List<int>();

            for (int i = 2; i < tokens.Length; i++)
            {
                element = int.Parse(tokens[i]);
                tokensToAdd.Add(element);
            }

            numbers.InsertRange(index, tokensToAdd);
        }
    }
}
