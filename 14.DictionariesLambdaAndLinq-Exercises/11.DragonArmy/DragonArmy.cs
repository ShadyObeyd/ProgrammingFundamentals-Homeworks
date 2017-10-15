using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.DragonArmy
{
    class DragonArmy
    {
        class Dragon
        {
            public int Damage { get; set; }
            public int Health { get; set; }
            public int Armor { get; set; }

            public Dragon (int damage, int health, int armor)
            {
                this.Damage = damage;
                this.Health = health;
                this.Armor = armor;
            }
        }

        static void Main()
        {
           var dragonsData = new Dictionary<string, SortedDictionary<string, Dragon>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string type = tokens[0];
                string name = tokens[1];
                int dmg = 0;
                int hp = 0;
                int armor = 0;

                if (tokens[2] == "null")
                {
                    dmg = 45;
                }
                else
                {
                    dmg = int.Parse(tokens[2]);
                }

                if (tokens[3] == "null")
                {
                    hp = 250;
                }
                else
                {
                    hp = int.Parse(tokens[3]);
                }

                if (tokens[4] == "null")
                {
                    armor = 10;
                }
                else
                {
                    armor = int.Parse(tokens[4]);
                }

                Dragon dragon = new Dragon(dmg, hp, armor);

                if (!dragonsData.ContainsKey(type))
                {
                    dragonsData.Add(type, new SortedDictionary<string, Dragon>());
                }

                if (!dragonsData[type].ContainsKey(name))
                {
                    dragonsData[type].Add(name, dragon);
                }
                dragonsData[type][name] = dragon;
            }

            foreach (var data in dragonsData)
            {
                string type = data.Key;
                SortedDictionary<string, Dragon> statsData = data.Value;

                double averageDmg = statsData.Values.Average(d => d.Damage);
                double averageHealth = statsData.Values.Average(h => h.Health);
                double averageArmor = statsData.Values.Average(a => a.Armor);

                Console.WriteLine($"{type}::({averageDmg:f2}/{averageHealth:f2}/{averageArmor:f2})");

                foreach (KeyValuePair<string, Dragon> stats in statsData)
                {
                    string name = stats.Key;
                    Dragon dragon = stats.Value;

                    Console.WriteLine($"-{name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
                }
            }
        }
    }
}
