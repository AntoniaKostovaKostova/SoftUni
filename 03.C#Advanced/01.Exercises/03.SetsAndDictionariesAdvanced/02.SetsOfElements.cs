using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = numbers[0];
            int m = numbers[1];

            HashSet<int> nSet = new HashSet<int>();
            HashSet<int> mSet = new HashSet<int>();
            HashSet<int> resultSet = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                nSet.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < m; i++)
            {
                mSet.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var item in nSet)
            {
              if(mSet.Remove(item))
                {
                    resultSet.Add(item);
                }
            }     
            
            Console.WriteLine(string.Join(" ", resultSet));
        }
    }
}
