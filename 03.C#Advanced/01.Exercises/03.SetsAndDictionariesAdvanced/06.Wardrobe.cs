using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] line = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string colour = line[0];

                string[] clothesOfColor = line[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

                if (!clothes.ContainsKey(colour))
                {
                    clothes.Add(colour, new Dictionary<string, int>());

                }

                for (int j = 0; j < clothesOfColor.Length; j++)
                {
                    if (!clothes[colour].ContainsKey(clothesOfColor[j]))
                    {
                        clothes[colour].Add(clothesOfColor[j], 0);
                    }

                    clothes[colour][clothesOfColor[j]] += 1;

                }
            }
            string[] search = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string searchedColour = search[0];
            string searchedCloth = search[1];

            foreach (var kvp in clothes)
            {
                Console.WriteLine($"{kvp.Key} clothes:");

                foreach (var keyIn in kvp.Value)
                {
                    if (kvp.Key == searchedColour && keyIn.Key == searchedCloth)
                    {
                           Console.WriteLine($"* {keyIn.Key} - {keyIn.Value} (found!)");
                    }
                    else
                    {
                           Console.WriteLine($"* {keyIn.Key} - {keyIn.Value}");
                    }
                }
            }
        }
    }
}

