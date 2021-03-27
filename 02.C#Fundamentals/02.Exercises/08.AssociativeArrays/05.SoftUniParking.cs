using System;
using System.Collections.Generic;

namespace Ex05SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var registered = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (commands.Length == 3)
                {
                    string username = commands[1];
                    string number = commands[2];

                    if (!registered.ContainsKey(username))
                    {
                        registered.Add(commands[1], number);
                        Console.WriteLine($"{username} registered {number} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {number}");
                    }
                }
                if (commands.Length == 2)
                {
                    string username = commands[1];

                    if (!registered.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        registered.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }

            }
            foreach (var student in registered)
            {
                Console.WriteLine($"{student.Key} => {student.Value}");
            }
        }
    }
}
