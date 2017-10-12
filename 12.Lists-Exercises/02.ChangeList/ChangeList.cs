using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChangeList
{
    class ChangeList
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine().ToLower();
            
            while (command != "odd" && command != "even")
            {
                string[] tokens = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
                int element = int.Parse(tokens[1]);
            
                switch (tokens[0])
                {
                    case "delete":
                        DeleteElements(numbers, element);
                        break;
                    case "insert":
                        int index = int.Parse(tokens[2]);
                        numbers.Insert(index, element);
                        break;
                }
            
                command = Console.ReadLine().ToLower();
            }

            if (command == "odd")
            {
                numbers =
                    numbers.Where(n => n % 2 != 0)
                    .ToList();
            }
            else if (command == "even")
            {
                numbers =
                    numbers.Where(n => n % 2 == 0)
                    .ToList();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void DeleteElements(List<int> numbers, int element)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == element)
                {
                    numbers.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}
