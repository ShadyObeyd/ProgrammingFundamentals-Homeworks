using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.NetherRealms
{
    class NetherRealms
    {
        static void Main()
        {
            Regex healthPattern = new Regex(@"[^\d\+\*\/\-\.]");
            Regex damagePattern = new Regex(@"[\-\+]?[\d\.]+");
            string[] input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).OrderBy(n => n).ToArray();

            List<string> demons = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                string currentDemon = input[i].Trim();

                int health = CalculateHealth(currentDemon, healthPattern);
                double dmg = CalculateDamage(currentDemon, damagePattern);

                Console.WriteLine($"{currentDemon} - {health} health, {dmg:f2} damage");
            }
        }

        static double CalculateDamage(string currentDemon, Regex damagePattern)
        {
            double damage = 0;

            MatchCollection matches = damagePattern.Matches(currentDemon);

            foreach (Match match in matches)
            {
                damage += double.Parse(match.Value);
            }

            foreach (char symbol in currentDemon)
            {
                if (symbol == '*')
                {
                    damage *= 2;
                }
                else if (symbol == '/')
                {
                    damage /= 2;
                }
            }

            return damage;
        }

        static int CalculateHealth(string currentDemon, Regex healthPattern)
        {
            int health = 0;

            MatchCollection matches = healthPattern.Matches(currentDemon);

            foreach (Match match in matches)
            {
                health += match.Value[0];
            }
            return health;
        }
    }
}
