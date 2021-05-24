using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] operations = ReadFromConsole();

            int n = operations[0];
            int s = operations[1];
            int x = operations[2];

            Queue<int> queue = new Queue<int>();

            int[] numbersToPush = ReadFromConsole();

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(numbersToPush[i]);
            }

            for (int j = 0; j < s; j++)
            {
                queue.Dequeue();
            }

            if (queue.Count <= 0)
            {
                Console.WriteLine('0');
            }
            else if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
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
