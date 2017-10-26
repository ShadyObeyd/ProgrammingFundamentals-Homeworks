using System;
using System.Text;

namespace _06.SumBigNumbers
{
    class SumBigNumbers
    {
        static void Main()
        {
            string firstNumber = Console.ReadLine().Trim();
            string secondNumber = Console.ReadLine().Trim();

            if (firstNumber.Length > secondNumber.Length)
            {
                secondNumber = secondNumber.PadLeft(firstNumber.Length, '0');
            }
            else
            {
                firstNumber = firstNumber.PadLeft(secondNumber.Length, '0');
            }

            int sum = 0;
            StringBuilder resultAsBuilder = new StringBuilder();
            int numberInMind = 0;
            int remainder = 0;

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                sum = (firstNumber[i] - '0') + (secondNumber[i] - '0') + numberInMind;
                numberInMind = sum / 10;
                remainder = sum % 10;
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
