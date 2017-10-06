using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.GeometryCalculator
{
    class GeometryCalculator
    {
        static void Main()
        {
            string figureType = Console.ReadLine().ToLower();

            if (figureType == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double triangleArea = GetTriangleArea(side, height);
                Console.WriteLine($"{triangleArea:f2}");
            }
            else if (figureType == "square")
            {
                double side = double.Parse(Console.ReadLine());

                double squareArea = GetSquareArea(side);
                Console.WriteLine($"{squareArea:f2}");
            }
            else if (figureType == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double rectangleArea = GetRectangleArea(width, height);
                Console.WriteLine($"{rectangleArea:f2}");
            }
            else if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                double circleArea = GetCircleArea(radius);
                Console.WriteLine($"{circleArea:f2}");
            }
        }

        private static double GetCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        private static double GetRectangleArea(double width, double height)
        {
            return width * height;
        }

        private static double GetSquareArea(double side)
        {
            return side * side;
        }

        private static double GetTriangleArea(double side, double height)
        {
            return side * height / 2;
        }
    }
}
