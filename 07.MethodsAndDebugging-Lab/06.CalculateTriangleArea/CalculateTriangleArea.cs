using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CalculateTriangleArea
{
    class CalculateTriangleArea
    {
        static void Main()
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double triangleArea = GetTriangleArea(height, width);

            Console.WriteLine(triangleArea);
        }

        private static double GetTriangleArea(double height, double width)
        {
            return (height * width) / 2;
        }
    }
}
