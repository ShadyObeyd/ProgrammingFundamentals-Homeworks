using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ExtractMiddle1Or2Or3Elements
{
    class ExtractMiddle1Or2Or3Elements
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (numbers.Length == 1)
            {
                Console.WriteLine($"{{ {numbers[0]} }}");
            }
            else if (numbers.Length % 2 == 0)
            {
                TakeMiddleTwoElements(numbers);
            }
            else if (numbers.Length % 2 != 0)
            {
                TakeMiddleThreeElements(numbers);
            }
        }

        static void TakeMiddleThreeElements(int[] numbers)
        {
            int[] reslut = new int[3];
            reslut[0] = numbers[numbers.Length / 2 - 1];
            reslut[1] = numbers[numbers.Length / 2];
            reslut[2] = numbers[numbers.Length / 2 + 1];

            Console.WriteLine($"{{ {reslut[0]}, {reslut[1]}, {reslut[2]} }}");
        }

        static void TakeMiddleTwoElements(int[] numbers)
        {
            int[] reslut = new int[2];
            reslut[0] = reslut[0] = numbers[numbers.Length / 2 - 1];
            reslut[1] = numbers[numbers.Length / 2];

            Console.WriteLine($"{{ {reslut[0]}, {reslut[1]} }}");
        }
    }
}
