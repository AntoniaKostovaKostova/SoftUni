using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace Ex02Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string[] commands = Console.ReadLine().Split();

            List<int> list = new List<int>();
            list = sequence.ToList();

            while (commands[0] != "Mort")
            {
                switch (commands[0])
                {
                    case "Add":
                        list.Add(int.Parse(commands[1]));
                        break;
                    case "Remove":
                        list.Remove(int.Parse(commands[1]));
                        break;
                    case "Replace":
                        int replaceIndex = list.IndexOf(int.Parse(commands[1]));
                        list.RemoveAt(replaceIndex);
                        list.Insert(replaceIndex, int.Parse(commands[2]));
                        break;
                    case "Collapse":
                        int collapseValue = int.Parse(commands[1]);

                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] < collapseValue)
                            {
                                list.Remove(list[i]);
                                i--;
                            }
                        }

                        break;
                    default:
                        break;
                }
                commands = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", list));

        }
    }
}
