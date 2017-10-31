using System;
using System.Text.RegularExpressions;

namespace _04.WinningTicket
{
    class WinningTicket
    {
        static void Main()
        {
            Regex validTicketPattern = new Regex(@"^.{20}$");
            Regex dswinnerPattern = new Regex(@"^.*#{6,9}.*$");
            Regex doller = new Regex(@"^.*\${6,9}.*$");
            Regex beakWinnerPattern = new Regex(@"^.*\^{6,9}.*$");
            Regex klemoveWinnerPattern = new Regex(@"^.*@{6,9}.*$");

            string[] tickets = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string currentTicket in tickets)
            {
                if (validTicketPattern.IsMatch(currentTicket))
                {
                    string leftPart = currentTicket.Substring(0, 10);
                    string rightPart = currentTicket.Substring(10);

                    int counter = 0;

                    if (currentTicket == new string('#', 20))
                    {
                        Console.WriteLine($"ticket \"{currentTicket}\" - 10# Jackpot!");
                    }
                    else if (currentTicket == new string('$', 20))
                    {
                        Console.WriteLine($"ticket \"{currentTicket}\" - 10$ Jackpot!");
                    }
                    else if (currentTicket == new string('^', 20))
                    {
                        Console.WriteLine($"ticket \"{currentTicket}\" - 10^ Jackpot!");
                    }
                    else if (currentTicket == new string('@', 20))
                    {
                        Console.WriteLine($"ticket \"{currentTicket}\" - 10@ Jackpot!");
                    }
                    else
                    {
                        if (dswinnerPattern.IsMatch(leftPart) && dswinnerPattern.IsMatch(rightPart))
                        {
                            counter = CountSymbols(leftPart, rightPart, '#');
                            Console.WriteLine($"ticket \"{currentTicket}\" - {counter}#");
                        }
                        else if (doller.IsMatch(leftPart) && doller.IsMatch(rightPart))
                        {
                            counter = CountSymbols(leftPart, rightPart, '$');
                            Console.WriteLine($"ticket \"{currentTicket}\" - {counter}$");
                        }
                        else if (beakWinnerPattern.IsMatch(leftPart) && beakWinnerPattern.IsMatch(rightPart))
                        {
                            counter = CountSymbols(leftPart,rightPart, '^');
                            Console.WriteLine($"ticket \"{currentTicket}\" - {counter}^");
                        }
                        else if (klemoveWinnerPattern.IsMatch(leftPart) && klemoveWinnerPattern.IsMatch(rightPart))
                        {
                            counter = CountSymbols(leftPart, rightPart, '@');
                            Console.WriteLine($"ticket \"{currentTicket}\" - {counter}@");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{currentTicket}\" - no match");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
        static int CountSymbols(string leftPart, string rightPart, char specialSymbol)
        {
            char[] rightSymbols = rightPart.ToCharArray();
            char[] leftSymbols = leftPart.ToCharArray();

            int rightCnt = CountLeftAndRigntPart(rightSymbols, specialSymbol);
            int leftCnt = CountLeftAndRigntPart(leftSymbols, specialSymbol);

            
            return Math.Min(rightCnt, leftCnt);
        }
        static int CountLeftAndRigntPart(char[] arr, char specialSymbol)
        {
            int cntr = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == specialSymbol)
                {
                    cntr++;
                }
            }
            return cntr;
        }
    }
}