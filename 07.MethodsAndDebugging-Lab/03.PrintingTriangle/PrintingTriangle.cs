using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PrintingTriangle
{
    class PrintingTriangle
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                PrintTriangleLine(1, i);
            }
            PrintTriangleLine(1, n);

            for (int i = n - 1; i >= 0; i--)
            {
                PrintTriangleLine(1, i);
            }
        }

        private static void PrintTriangleLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
