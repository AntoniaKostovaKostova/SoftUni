using System;
using System.Collections.Generic;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> sortedSet = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                foreach (var element in elements)
                {
                    sortedSet.Add(element);
                }
            }

            Console.WriteLine(string.Join(" ", sortedSet));
        }
    }
}
