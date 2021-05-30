using System;
using System.Collections.Generic;

namespace _01.UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> sortedSet = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                sortedSet.Add(Console.ReadLine());
            }
            foreach (var username in sortedSet)
            {
                Console.WriteLine(username);
            }
        }
    }
}
