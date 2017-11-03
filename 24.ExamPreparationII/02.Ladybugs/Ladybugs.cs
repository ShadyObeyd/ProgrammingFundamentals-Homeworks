using System;
using System.Linq;

namespace _02.Ladybugs
{
    class Ladybugs
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string[] field = new string[n];

            int[] ladybugsIndexes = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            InitializeField(field, ladybugsIndexes);

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] commandTokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int ladybugIndex = int.Parse(commandTokens[0]);
                string direction = commandTokens[1].ToLower();
                int flyLenght = int.Parse(commandTokens[2]);

                if (ladybugIndex >= 0 && ladybugIndex < field.Length)
                {
                    if (field[ladybugIndex] == "1")
                    {
                        field[ladybugIndex] = "0";

                        switch (direction)
                        {
                            case "left":
                                if (flyLenght >= 0)
                                {
                                    MoveLeft(flyLenght, ladybugIndex, field);
                                }
                                else
                                {
                                    MoveRight(flyLenght, ladybugIndex, field);
                                }
                                break;
                            case "right":
                                if (flyLenght >= 0)
                                {
                                    MoveRight(flyLenght, ladybugIndex, field);
                                }
                                else
                                {
                                    MoveLeft(flyLenght, ladybugIndex, field);
                                }
                                break;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }

        static void MoveLeft(int flyLenght, int ladybugIndex, string[] field)
        {
            flyLenght = Math.Abs(flyLenght);

            for (int i = ladybugIndex - flyLenght; i >= 0; i-= flyLenght)
            {
                if (field[i] == "0")
                {
                    field[i] = "1";
                    break;
                }
            }

        }

        static void MoveRight(int flyLenght, int ladybugIndex, string[] field)
        {
            flyLenght = Math.Abs(flyLenght);

            for (int i = ladybugIndex + flyLenght; i < field.Length; i+= flyLenght)
            {
                if (field[i] == "0")
                {
                    field[i] = "1";
                    break;
                }
            }
        }

        static void InitializeField(string[] field, int[] ladybugsIndexes)
        {
            for (int i = 0; i < field.Length; i++)
            {
                if (ladybugsIndexes.Contains(i))
                {
                    field[i] = "1";
                }
                else
                {
                    field[i] = "0";
                }
            }
        }
    }
}
