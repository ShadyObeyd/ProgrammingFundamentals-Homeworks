using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.MultiplicationTable2._0
{
    class MultiplicationTable2
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int devider = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine($"{number} X {devider} = {number * devider}");
                devider++;
            } while (devider <= 10);
        }
    }
}
