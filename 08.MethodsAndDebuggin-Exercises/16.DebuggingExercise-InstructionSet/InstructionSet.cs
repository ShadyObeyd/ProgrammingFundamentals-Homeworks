using System;
using System.Numerics;

class InstructionSet_broken
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();

        while (input != "end")
        {
            string[] tokens = input.Split(' ');

            BigInteger result = 0;
            switch (tokens[0])
            {
                case "inc":
                    {
                        BigInteger operandOne = BigInteger.Parse(tokens[1]);
                        result = ++operandOne;
                        break;
                    }
                case "dec":
                    {
                        BigInteger operandOne = BigInteger.Parse(tokens[1]);
                        result = --operandOne;
                        break;
                    }
                case "add":
                    {
                        BigInteger operandOne = BigInteger.Parse(tokens[1]);
                        BigInteger operandTwo = BigInteger.Parse(tokens[2]);
                        result = operandOne + operandTwo;
                        break;
                    }
                case "mla":
                    {
                        BigInteger operandOne = BigInteger.Parse(tokens[1]);
                        BigInteger operandTwo = BigInteger.Parse(tokens[2]);
                        result = operandOne * operandTwo;
                        break;
                    }
            }

            Console.WriteLine(result);

            input = Console.ReadLine().ToLower();
        }
    }
}
