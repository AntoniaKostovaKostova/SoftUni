using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex09ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var games = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "Lumpawaroo")
            {
                if (input.Contains(" | "))
                {
                    string[] line =  input.Split(" | ");
                    var forceSide = line[0];
                    var forceUser = line[1];

                    if (!games.ContainsKey(forceSide))
                    {
                        games.Add(forceSide, new List<string>());
                    }

                    bool isContains = false;

                    //if (games.Values.Any(x => x.Contains(forceUser)) == false)
                    //{
                    //    games[forceSide].Add(forceUser);
                    //}

                    foreach (var value in games.Values)
                    {
                        foreach (var user in value)
                        {
                            if (user.Equals(forceUser))
                            {
                                isContains = true;
                                break;
                            }
                        }
                    }

                    if (!isContains)
                    {
                        games[forceSide].Add(forceUser);
                    }
                }
                else        
                {
                    var line = input.Split(" -> ");
                    var forceUser = line[0];
                    var forceSide = line[1];

                    bool isContains = false;
                    string side = string.Empty;
                    foreach (var game in games)
                    {
                        foreach (var user in game.Value)
                        {
                            if (user.Equals(forceUser))
                            {
                                isContains = true;
                                side = game.Key;
                                break;
                            }
                        }
                    }
                    if (isContains)
                    {
                        games[side].Remove(forceUser);
                    }
                 

                    if (!games.ContainsKey(forceSide))
                    {
                        games.Add(forceSide, new List<string>());
                    }
                    games[forceSide].Add(forceUser);
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }

                input = Console.ReadLine();
            }

            var orderedGame = games.OrderByDescending(a => a.Value.Count).ThenBy(k => k.Key);//

            foreach (var kvp in orderedGame.Where(a => a.Value.Count > 0))//
            {
                Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");

                foreach (var value in kvp.Value.OrderBy(k => k))//
                {
                    Console.WriteLine($"! {value}");
                }

            }
        }
    }
}
