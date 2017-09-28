using System;

namespace _05.CharacterStats
{
    class CharacterStats
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int currentHP = int.Parse(Console.ReadLine());
            int maxHP = int.Parse(Console.ReadLine());
            int currentMana = int.Parse(Console.ReadLine());
            int maxMana = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{new string('|', currentHP)}{new string('.', maxHP - currentHP)}|");
            Console.WriteLine($"Energy: |{new string('|', currentMana)}{new string('.', maxMana - currentMana)}|");
        }
    }
}
