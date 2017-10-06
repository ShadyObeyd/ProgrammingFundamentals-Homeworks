using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumbersInReversedOrder
{
    class NumbersInReversedOrder
    {
        static void Main()
        {
            string num = Console.ReadLine();


            Console.WriteLine(Reverse(num));
        }

        public static string Reverse(string num)
        {
            char[] cArray = num.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
    }
}
