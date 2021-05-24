using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] operations = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = operations[0];
            int s = operations[1];
            int x = operations[2];

            Stack<int> stack = new Stack<int>();

            int[] numbersToPush = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            for (int i = 0; i < n; i++)
            {
                stack.Push(numbersToPush[i]);
            }

            for (int j = 0; j < s; j++)
            {
                stack.Pop();
            }

            if (stack.Count <= 0)
            {
                Console.WriteLine('0');
            }
            else if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
