using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex03Problem3
{
    class Program
    {
        static void Main(string[] args)
        {

            int capacity = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();

            Dictionary<string, List<int>> records = new Dictionary<string, List<int>>();

            while (line != "Statistics")
            {
                string[] commands = line.Split("=", StringSplitOptions.RemoveEmptyEntries);

                string mainCommand = commands[0];

                if (mainCommand == "Add")
                {
                    string username = commands[1];
                    int send = int.Parse(commands[2]);
                    int received = int.Parse(commands[3]);

                    if (!records.ContainsKey(username))
                    {
                        records.Add(username, new List<int> { send, received });
                    }
                }

                else if (mainCommand == "Message")
                {
                    string sender = commands[1];
                    string receiver = commands[2];

                    if (records.ContainsKey(sender) && records.ContainsKey(receiver))
                    {
                        records[sender][0] += 1;
                        records[receiver][1] += 1;

                        if (records[sender][0] + records[sender][1] >= capacity)
                        {
                            records.Remove(sender);
                            Console.WriteLine($"{sender} reached the capacity!");
                        }

                        if (records[receiver][0] + records[receiver][1] >= capacity)
                        {
                            records.Remove(receiver);
                            Console.WriteLine($"{receiver} reached the capacity!");
                        }
                    }

                }

                else if (mainCommand == "Empty")
                {
                    string username = commands[1];

                    if (username != "All")
                    {
                        records.Remove(username);
                    }
                    else
                    {
                        records.Clear();
                    }
                }

                line = Console.ReadLine();
            }

            Console.WriteLine($"Users count: {records.Count}");

            records = records.OrderByDescending(r => r.Value[1]).ThenBy(n => n.Key).ToDictionary(k => k.Key, v => v.Value);


            foreach (var item in records)
            {
                Console.WriteLine($"{item.Key} - {item.Value[0] + item.Value[1]}");
            }
        }

    }
}
