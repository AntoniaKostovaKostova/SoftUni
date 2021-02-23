using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex05BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int bomb = array[0];
            int strenght = array[1];

            while (sequence.Contains(bomb))
            {               
                int bombIndex = sequence.IndexOf(bomb);
                if (strenght == 0)
                {
                    sequence.RemoveAt(bombIndex);
                }
                else
                {
                    int startIndex = bombIndex - strenght;

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    int count = 2 * strenght + 1;
                    if (startIndex + count > sequence.Count - startIndex)
                    {
                        count = sequence.Count - startIndex;
                    }
                    sequence.RemoveRange(startIndex, count);
                }
            }
            int sum = 0;
            foreach (var item in sequence)
            {
                sum += item;
            }

            Console.WriteLine(sum);
        }
    }
}
