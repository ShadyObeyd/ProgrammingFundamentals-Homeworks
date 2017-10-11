using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AppendList
{
    class AppendList
    {
        static void Main()
        {
            List<string> numbers = Console.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            numbers.Reverse();
            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                List<int> lists = numbers[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

                result.AddRange(lists);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
