using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace Ex04ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<string> commands = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string operation = commands[0];
            while (operation != "End")
            {
                if (operation == "Add")
                {
                    int number = int.Parse(commands[1]);
                    integers.Add(number);
                }
                else if (operation == "Insert")
                {
                    int index = int.Parse(commands[2]);

                    if (index > integers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        int number = int.Parse(commands[1]);
                        integers.Insert(index, number);
                    }
                }
                else if (operation == "Remove")
                {
                    int index = int.Parse(commands[1]);

                    if (index > integers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        integers.RemoveAt(index);
                    }
                }
                else if (operation == "Shift")
                {
                    string direction = commands[1];
                    int count = int.Parse(commands[2]);

                    if (direction == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            integers.Add(integers[0]);
                            integers.RemoveAt(0);
                        }
                    }
                    else if (direction == "right")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int lastNumber = integers[integers.Count - 1];

                            integers.RemoveAt(integers.Count - 1);
                            integers.Insert(0, lastNumber);
                        }
                    }
                }
                commands = Console.ReadLine()
                .Split()
                .ToList();

                operation = commands[0];
            }
            Console.WriteLine(String.Join(" ", integers));
        }
    }
}
