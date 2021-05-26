using System;
using System.Collections.Generic;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> songsQueue = new Queue<string>(songs);

            while (songsQueue.Count > 0)
            {
                string[] commandLine = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = commandLine[0];

                if (command == "Play")
                {
                    songsQueue.Dequeue();
                }
                else if (command == "Add")
                {
                    string songName = string.Join(" ", commandLine).Substring(command.Length + 1);

                    if (songsQueue.Contains(songName))
                    {
                        Console.WriteLine($"{songName} is already contained!");
                    }
                    else
                    {
                        songsQueue.Enqueue(songName);
                    }
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songsQueue));
                }
                
            }

            if (songsQueue.Count == 0)
            {
                Console.WriteLine("No more songs!");
            }

        }
    }
}
