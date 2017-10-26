using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumBigNumbers
{
    class SumBigNumbers
    {
        static void Main()
        {
            string firstNumber = Console.ReadLine().Trim();
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber == "0" || secondNumber == 0)
            {
                Console.WriteLine(0);
                return;
            }

            int product = 0;
            StringBuilder resultAsBuilder = new StringBuilder();
            int numberInMind = 0;
            int remainder = 0;

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                product = (firstNumber[i] - '0') * secondNumber + numberInMind;
                numberInMind = product / 10;
                remainder = product % 10;
                resultAsBuilder.Append(remainder);

                if (i == 0 && numberInMind != 0)
                {
                    resultAsBuilder.Append(numberInMind);
                }

            }

            string result = resultAsBuilder.ToString().TrimEnd(new char[] { '0' });

            char[] finalResult = result.ToCharArray();

            Array.Reverse(finalResult);

            Console.WriteLine(finalResult);
        }
    }
}
