using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex03LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {

            var materials = new Dictionary<string, int>();

            materials.Add("shards", 0);
            materials.Add("fragments", 0);
            materials.Add("motes", 0);

            string[] input = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string sucessedObject = string.Empty;

            while (true)
            {
                string material = string.Empty;
                bool isSuccessed = false;

                for (int i = 1; i < input.Length; i += 2)
                {
                    material = input[i].ToLower();

                    if (!materials.ContainsKey(material))
                    {
                        materials.Add(material, 0);
                    }

                    int quantity = int.Parse(input[i - 1]);

                    materials[material] += quantity;

                    if (materials["shards"] >= 250)
                    {
                        isSuccessed = true;
                        sucessedObject = "Shadowmourne";
                        materials["shards"] -= 250;
                        break;
                    }
                    else if (materials["fragments"] >= 250)
                    {
                        isSuccessed = true;
                        sucessedObject = "Valanyr";
                        materials["fragments"] -= 250;
                        break;
                    }
                    else if (materials["motes"] >= 250)
                    {
                        isSuccessed = true;
                        sucessedObject = "Dragonwrath";
                        materials["motes"] -= 250;
                        break;
                    }
                }
                if (isSuccessed)
                {
                    break;
                }

                input = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"{sucessedObject} obtained!");

            var keyMaterials = materials.Where(m => m.Key == "shards" || m.Key == "fragments" || m.Key == "motes").
                OrderByDescending(m => m.Value).ThenBy(m => m.Key);

            foreach (var material in keyMaterials)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }

            var junkMaterials = materials.Where(m => m.Key != "shards" && m.Key != "fragments" && m.Key != "motes").
                OrderBy(m => m.Key);

            foreach (var material in junkMaterials)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }

        }
    }
}

