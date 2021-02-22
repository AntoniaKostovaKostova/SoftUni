using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex02ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] commandArray = Console.ReadLine().Split();

                string command = commandArray[0];

                if (command == "end")
                {
                    break;
                }

                int element = int.Parse(commandArray[1]);
                if (command == "Delete")
                {
                    integers.RemoveAll(i => i == element);
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(commandArray[2]);
                    integers.Insert(index, element);
                }

            }
            Console.WriteLine(string.Join(" ", integers));
        }
    }
}
