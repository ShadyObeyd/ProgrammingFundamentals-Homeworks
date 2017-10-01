using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.DifferentIntegersSize
{
    class DifferentIntegersSize
    {
        static void Main()
        {
            string num = Console.ReadLine();

            sbyte sbyteNum;
            byte byteNum;
            short shortNum;
            ushort ushortNum;
            int intNum;
            uint uintNum;
            long longNum;


            if (long.TryParse(num, out longNum))
            {
                Console.WriteLine($"{num} can fit in:");
                if (sbyte.TryParse(num, out sbyteNum))
                {
                    Console.WriteLine("* sbyte");
                }
                if (byte.TryParse(num, out byteNum))
                {
                    Console.WriteLine("* byte");
                }
                if (short.TryParse(num, out shortNum))
                {
                    Console.WriteLine("* short");
                }
                if (ushort.TryParse(num, out ushortNum))
                {
                    Console.WriteLine("* ushort");
                }
                if (int.TryParse(num, out intNum))
                {
                    Console.WriteLine("* int");
                }
                if (uint.TryParse(num, out uintNum))
                {
                    Console.WriteLine("* uint");
                }
                Console.WriteLine("* long");
            }
            else
            {
                Console.WriteLine($"{num} can't fit in any type");
            }
        }
    }
}
