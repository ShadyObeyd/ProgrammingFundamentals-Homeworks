using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RemoveNegativesAndReverse
{
    class RemoveNegativesAndReverse
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<int> reslutList = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNum = numbers[i];

                if (currentNum > 0)
                {
                    reslutList.Add(currentNum);
                }
            }


            if (reslutList.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                reslutList.Reverse();

                Console.WriteLine(string.Join(" ", reslutList));
            }
        }
    }
}
