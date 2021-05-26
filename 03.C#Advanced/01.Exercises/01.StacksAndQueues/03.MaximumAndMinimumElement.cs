using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] queries = ReadFromConsole();

                if (queries[0] == 1)
                {
                    stack.Push(queries[1]);
                }

                if (stack.Count <= 0)
                {
                    continue;
                }

                else if (queries[0] == 2)
                {
                    stack.Pop();
                }
                else if (queries[0] == 3)
                {
                    Console.WriteLine(stack.Max());
                }
                else if (queries[0] == 4)
                {
                    Console.WriteLine(stack.Min());
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
        private static int[] ReadFromConsole()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
