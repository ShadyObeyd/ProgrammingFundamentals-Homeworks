using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CubeProperties
{
    class CubeProperties
    {
        static double cubeSide;

        static void Main()
        {
            cubeSide = double.Parse(Console.ReadLine());
            string cubeParameter = Console.ReadLine().ToLower();

            if (cubeParameter == "face")
            {
                PrintFaceDiagonal();
            }
            else if (cubeParameter == "space")
            {
                PrintSpaceDiagonal();
            }
            else if (cubeParameter == "volume")
            {
                PrintVolume();
            }
            else if (cubeParameter == "area")
            {
                PrintSurfaceArea();
            }
        }

        private static void PrintFaceDiagonal()
        {
            double faceDiagonal = Math.Sqrt(2 * Math.Pow(cubeSide, 2));
            Console.WriteLine($"{faceDiagonal:f2}");
        }

        private static void PrintSpaceDiagonal()
        {
            double spaceDiagonal = Math.Sqrt(3 * Math.Pow(cubeSide, 2));
            Console.WriteLine($"{spaceDiagonal:f2}");
        }

        private static void PrintVolume()
        {
            double volume = Math.Pow(cubeSide, 3);
            Console.WriteLine($"{volume:f2}");
        }

        private static void PrintSurfaceArea()
        {
            double surfaceArea = 6 * Math.Pow(cubeSide, 2);
            Console.WriteLine($"{surfaceArea:f2}");
        }
    }
}
