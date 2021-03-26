using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex01CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

           string result = string.Join("", input);

            var dictionary = new Dictionary<char, int>();

            for (int i = 0; i < result.Length; i++)
            {
                if (dictionary.ContainsKey(result[i]))
                {
                    dictionary[result[i]] += 1;
                }
                else
                {
                    dictionary.Add(result[i], 1);
                }
            }

            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
