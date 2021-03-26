using System;
using System.Collections.Generic;

namespace Ex02AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string prevInput = string.Empty;
            int time = 1;
            var dictionary = new Dictionary<string, int>();

            while (input != "stop")
            {
                if (time % 2 != 0)
                {
                    if (!dictionary.ContainsKey(input))
                    {
                        dictionary.Add(input, 0);
                    }
                    prevInput = input;
                }
                else
                {
                    int quantity = int.Parse(input);

                    dictionary[prevInput] += quantity;
                }

                input = Console.ReadLine();
                time += 1;
            }

            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
