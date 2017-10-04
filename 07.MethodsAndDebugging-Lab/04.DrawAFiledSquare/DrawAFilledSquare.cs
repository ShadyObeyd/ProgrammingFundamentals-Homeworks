using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DrawAFiledSquare
{
    class DrawAFilledSquare
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintHeader(n);
            for (int i = 1; i < n - 1; i++)
            {
                PrintBody(n);
            }
            PrintHeader(n);
        }

        private static void PrintBody(int n)
        {
            Console.Write('-');
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }

        private static void PrintHeader(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
    }
}
