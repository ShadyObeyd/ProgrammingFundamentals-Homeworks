using System;

namespace _02.RectangleArea
{
    class RectangleArea
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine($"{width * height:f2}");
        }
    }
}
