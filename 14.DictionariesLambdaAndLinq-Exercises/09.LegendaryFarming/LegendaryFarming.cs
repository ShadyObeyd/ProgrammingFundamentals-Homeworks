using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LegendaryFarming
{
    class LegendaryFarming
    {
        static void Main()
        {
            Dictionary<string, int> legendaryData = new Dictionary<string, int>();
            SortedDictionary<string, int> junkData = new SortedDictionary<string, int>();

            int shardsCntr = 0;
            int fragmentsCntr = 0;
            int motesCntr = 0;

            while (shardsCntr < 250 && fragmentsCntr < 250 && motesCntr < 250)
            {
                string[] tokens = Console.ReadLine().ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 1; i < tokens.Length; i++)
                {
                    if (tokens[i] == "shards")
                    {
                        shardsCntr += int.Parse(tokens[i - 1]);

                        if (shardsCntr >= 250)
                        {
                            Console.WriteLine($"Shadowmourne obtained!");
                            break;
                        }
                    }
                    else if (tokens[i] == "fragments")
                    {
                        fragmentsCntr += int.Parse(tokens[i - 1]);

                        if (fragmentsCntr >= 250)
                        {
                            Console.WriteLine($"Valanyr obtained!");
                            break;
                        }
                    }
                    else if (tokens[i] == "motes")
                    {
                        motesCntr += int.Parse(tokens[i - 1]);

                        if (motesCntr >= 250)
                        {
                            Console.WriteLine($"Dragonwrath obtained!");
                            break;
                        }
                    }
                    else
                    {
                        bool isQuantity = CheckIfStringIsNumber(tokens[i]);

                        if (!isQuantity)
                        {
                            string material = tokens[i];
                            int quantity = int.Parse(tokens[i - 1]);

                            if (!junkData.ContainsKey(material))
                            {
                                junkData.Add(material, 0);
                            }
                            junkData[material] += quantity;
                        }
                    }
                }
            }
            AddMaterials(legendaryData, shardsCntr, "shards");
            AddMaterials(legendaryData, fragmentsCntr, "fragments");
            AddMaterials(legendaryData, motesCntr, "motes");

            foreach (KeyValuePair<string, int> materials in legendaryData.OrderByDescending(v => v.Value).ThenBy(k => k.Key))
            {
                string material = materials.Key;
                int quantity = materials.Value;

                Console.WriteLine($"{material}: {quantity}");
            }

            foreach (KeyValuePair<string, int> junk in junkData)
            {
                string material = junk.Key;
                int quantity = junk.Value;

                Console.WriteLine($"{material}: {quantity}");
            }
        }

        private static bool CheckIfStringIsNumber(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    return true;
                }
            }
            return false;
        }

        private static void AddMaterials(Dictionary<string, int> data, int materialCntr, string v)
        {
            if (!data.ContainsKey(v))
            {
                data.Add(v, 0);
            }

            if (materialCntr >= 250)
            {
                materialCntr -= 250;
            }
            data[v] = materialCntr;
        }
    }
}
