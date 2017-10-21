using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.IntersectionOfCircles
{
    class Circle
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Radius { get; set; }

        public Circle (double x, double y, double radius)
        {
            this.X = x;
            this.Y = y;
            this.Radius = radius;
        }
    }

    class IntersectionOfCircles
    {
        static void Main()
        {
            double[] firstCircleInput = ReadInput(Console.ReadLine());
            double[] secondCircleInput = ReadInput(Console.ReadLine());

            double x1 = firstCircleInput[0];
            double y1 = firstCircleInput[1];
            double r1 = firstCircleInput[2];

            double x2 = secondCircleInput[0];
            double y2 = secondCircleInput[1];
            double r2 = secondCircleInput[2];

            Circle firstCircle = new Circle(x1, y1, r1);
            Circle secondCircle = new Circle(x2, y2, r2);

            bool areIntersected = AreIntersected(firstCircle, secondCircle);

            if (areIntersected)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        private static bool AreIntersected(Circle firstCircle, Circle secondCircle)
        {
            double deltaX = Math.Pow((firstCircle.X - secondCircle.X), 2);
            double deltaY = Math.Pow((firstCircle.Y - secondCircle.Y), 2);

            double distance = Math.Sqrt(deltaX + deltaY);

            double radiusSum = firstCircle.Radius + secondCircle.Radius;

            if (radiusSum >= distance)
            {
                return true;
            }
            return false;
        }

        static double[] ReadInput (string input)
        {
            return input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
        }
    }
}
