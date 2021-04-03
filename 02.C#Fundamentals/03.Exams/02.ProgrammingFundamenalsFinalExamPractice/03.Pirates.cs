using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex03Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<long>> targets = new Dictionary<string, List<long>>();


            while (input != "Sail")
            {
                string[] information = input.Split("||", StringSplitOptions.RemoveEmptyEntries);

                string city = information[0];
                long population = long.Parse(information[1]);
                long gold = long.Parse(information[2]);

                if (!targets.ContainsKey(city))
                {
                    targets.Add(city, new List<long> { population, gold });
                }
                else
                {
                    targets[city][0] += population;
                    targets[city][1] += gold;
                }

                input = Console.ReadLine();
            }

            while (input != "End")
            {
                string[] information = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                if (information.Length == 4)
                {
                    string town = information[1];
                    long people = long.Parse(information[2]);
                    long gold = long.Parse(information[3]);

                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                    targets[town][0] -= people;
                    targets[town][1] -= gold;

                    if (targets[town][0] == 0 || targets[town][1] == 0)
                    {
                        targets.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                }
                else if (information.Length == 3)

                {
                    string town = information[1];
                    long gold = long.Parse(information[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                    }
                    else
                    {
                        targets[town][1] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {targets[town][1]} gold.");
                    }
                }

                input = Console.ReadLine();
            }

            Dictionary<string, List<long>> sortedTargets = targets
                .OrderByDescending(v => v.Value[1])
                .ThenBy(n => n.Key)
                .ToDictionary(k => k.Key, val => val.Value);

            if (sortedTargets.Count>0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {sortedTargets.Count} wealthy settlements to go to:");

                foreach (var target in sortedTargets)
                {
                    Console.WriteLine($"{target.Key} -> Population: {target.Value[0]} citizens, Gold: {target.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
