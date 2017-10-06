using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnglishNameOfTheLastDigit
{
    class EnglishNameOfTheLastDigit
    {
        static void Main()
        {
            string num = Console.ReadLine();

            string lastDigit = num.Last().ToString();

            string lastDigitName = GetNameOfDigit(lastDigit);

            Console.WriteLine(lastDigitName);
        }

        private static string GetNameOfDigit(string lastDigit)
        {
            string digitName = "";
        
            if (lastDigit == "0")
            {
                digitName = "zero";
            }
            else if (lastDigit == "1")
            {
                digitName = "one";
            }
            else if (lastDigit == "2")
            {
                digitName = "two";
            }
            else if (lastDigit == "3")
            {
                digitName = "three";
            }
            else if (lastDigit == "4")
            {
                digitName = "four";
            }
            else if (lastDigit == "5")
            {
                digitName = "five";
            }
            else if (lastDigit == "6")
            {
                digitName = "six";
            }
            else if (lastDigit == "7")
            {
                digitName = "seven";
            }
            else if (lastDigit == "8")
            {
                digitName = "eight";
            }
            else if (lastDigit == "9")
            {
                digitName = "nine";
            }
        
            return digitName;
        }
    }
}
