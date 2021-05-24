using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());

            int[] quantityofOrder = ReadFromConsole();

            Queue<int> quantityofOrderQueue = new Queue<int>();

            foreach (var order in quantityofOrder)
            {
                quantityofOrderQueue.Enqueue(order);
            }

            Console.WriteLine(quantityofOrderQueue.Max());

            while (quantityofOrderQueue.Count > 0 && quantityOfFood >= quantityofOrderQueue.Peek())
            {
                quantityOfFood -= quantityofOrderQueue.Dequeue();

                if (quantityofOrderQueue.Count == 0)
                {
                    Console.WriteLine("Orders complete");
                    break;
                }
            }

            if (quantityofOrderQueue.Count > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", quantityofOrderQueue)}");
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
