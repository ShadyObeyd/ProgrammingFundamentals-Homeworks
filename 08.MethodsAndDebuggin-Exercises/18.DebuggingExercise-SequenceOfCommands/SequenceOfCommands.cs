using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SequenceOfCommands
{

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine()); // We don't actually need this, but the problem requires it...

        List<long> numbers = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();

        string commands = Console.ReadLine().ToLower();

        while (commands != "stop")
        {
            string[] tokens = commands.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int index = 0;
            switch (tokens[0])
            {
                case "multiply":
                    index = int.Parse(tokens[1]) - 1;
                    int multiplier = int.Parse(tokens[2]);
                    numbers[index] *= multiplier;
                        break;
                case "add":
                    index = int.Parse(tokens[1]) - 1;
                    int addend = int.Parse(tokens[2]);
                    numbers[index] += addend;
                    break;
                case "subtract":
                    index = int.Parse(tokens[1]) - 1;
                    int substractend = int.Parse(tokens[2]);
                    numbers[index] -= substractend;
                    break;
                case "rshift":
                    RollRight(numbers);
                    break;
                case "lshift":
                    RollLeft(numbers);
                    break;
            }
            Console.WriteLine(string.Join(" ", numbers));
            commands = Console.ReadLine().ToLower();
        }
    }

    private static void RollLeft(List<long> numbers)
    {
        long num = numbers[0];
        numbers.Remove(num);
        numbers.Insert(numbers.Count, num);
    }

    private static void RollRight(List<long> numbers)
    {
        long num = numbers.Last();
        numbers.Remove(num);
        numbers.Insert(0, num);
    }
}
