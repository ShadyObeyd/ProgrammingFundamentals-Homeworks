using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CircleArea
{
    class CircleArea
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine($"{Math.PI * r * r:f12}");
        }
    }
}
