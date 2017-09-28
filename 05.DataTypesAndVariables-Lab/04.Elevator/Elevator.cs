using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Elevator
{
    class Elevator
    {
        static void Main()
        {
            int peopleCnt = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Ceiling((double)peopleCnt / elevatorCapacity));
        }
    }
}
