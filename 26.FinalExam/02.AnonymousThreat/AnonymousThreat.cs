using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AnonymousThreat
{
    class AnonymousThreat
    {
        static void Main()
        {
            List<string> list = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();

            while (input != "3:1")
            {
                string[] tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0].ToLower();

                switch (tokens[0])
                {
                    case "merge":
                        int startIndex = int.Parse(tokens[1]);
                        int endIndex = int.Parse(tokens[2]);
                        list = MergeItems(startIndex, endIndex, list);
                        break;
                    case "divide":
                        int index = int.Parse(tokens[1]);
                        int partitions = int.Parse(tokens[2]);
                        list = DivideItems(index, partitions, list);
                        break;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", list));
        }

        static List<string> DivideItems(int index, int partitions, List<string> list)
        {
            List<string> temp = new List<string>();

            string toDivide = list[index];

            int lenght = toDivide.Length / partitions;

            for (int i = 0; i < partitions; i++)
            {
                if (i == partitions - 1)
                {
                    string divided = toDivide.Substring(i * lenght);
                    temp.Add(divided);
                }
                else
                {
                    string divided = toDivide.Substring(i * lenght, lenght);
                    temp.Add(divided);
                }
            }
            list.RemoveAt(index);
            list.InsertRange(index, temp);

            return list;
        }

        static List<string> MergeItems(int startIndex, int endIndex, List<string> list)
        {
            startIndex = ValidateIndex(startIndex, list.Count);
            endIndex = ValidateIndex(endIndex, list.Count);

            List<string> temp = new List<string>();

            for (int i = 0; i < startIndex; i++)
            {
                temp.Add(list[i]);
            }

            StringBuilder builder = new StringBuilder();

            for (int i = startIndex; i <= endIndex; i++)
            {
                builder.Append(list[i]);
            }
            temp.Add(builder.ToString());

            for (int i = endIndex + 1; i < list.Count; i++)
            {
                temp.Add(list[i]);
            }
            return temp;
        }

        private static int ValidateIndex(int index, int lenght)
        {
            if (index < 0)
            {
                index = 0;
            }

            if (index >= lenght)
            {
                index = lenght - 1;
            }

            return index;
        }
    }
}
