using System;
using System.Collections.Generic;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int n = input.Length;

            SortedDictionary<char, int> dictionary = new SortedDictionary<char, int>();

            for (int i = 0; i < n; i++)
            {
                if (!dictionary.ContainsKey(input[i]))
                {
                    dictionary.Add(input[i], 0);
                }
                dictionary[input[i]] += 1;
            }            

            foreach (var character in dictionary)
            {
                Console.WriteLine($"{character.Key}: {character.Value} time/s");
            }
        }
    }
}
