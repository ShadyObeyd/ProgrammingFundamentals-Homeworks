using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            char[] firstArr = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
            char[] secondArr = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

            if (firstArr.Length > secondArr.Length)
            {
                PrintFirstString(secondArr, firstArr);
            }
            else if (secondArr.Length > firstArr.Length)
            {
                PrintFirstString(firstArr, secondArr);
            }
            else if (firstArr.Length == secondArr.Length)
            {
                PrintFirstString(firstArr, secondArr);
            }
        }

        private static void PrintFirstString(char[] arr1, char[] arr2)
        {
            string firstString = CreateString(arr1);
            string secondString = CreateString(arr2);

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] > arr2[i])
                {
                    Console.WriteLine(secondString);
                    Console.WriteLine(firstString);
                    break;
                }
                else if (arr1[i] < arr2[i])
                {
                    Console.WriteLine(firstString);
                    Console.WriteLine(secondString);
                    break;
                }
                else if (arr1[i] == arr2[i])
                {
                    if (firstString.Length >= secondString.Length)
                    {
                        Console.WriteLine(secondString);
                        Console.WriteLine(firstString);
                        break;
                    }
                    else
                    {
                        Console.WriteLine(firstString);
                        Console.WriteLine(secondString);
                        break;

                    }
                }
            }
        }

        private static string CreateString(char[] arr)
        {
            string result = string.Empty;

            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }

            return result;
        }
    }
}
