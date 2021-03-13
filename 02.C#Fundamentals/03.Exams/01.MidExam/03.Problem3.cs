using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex03Problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine()
                .Split();

            List<string> chat = new List<string>();

            while (commands[0] != "end")
            {
                if (commands[0] == "Chat")
                {
                    chat.Add(commands[1]);
                }
                else if (commands[0] == "Delete")
                {
                    if (chat.Contains(commands[1]))
                    {
                        chat.Remove(commands[1]);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (commands[0] == "Edit")
                {
                    int index = chat.IndexOf(commands[1]);
                    chat.RemoveAt(index);
                    chat.Insert(index, commands[2]);
                    //chat[index] = commands[2];
                }
                else if (commands[0] == "Pin")
                {
                    int index = chat.IndexOf(commands[1]);
                    chat.RemoveAt(index);
                    chat.Add(commands[1]);
                }
                else if (commands[0] == "Spam")
                {
                    chat.AddRange(commands.Skip(1));
                    //chat.Remove("Spam");
                }

                commands = Console.ReadLine()
                    .Split();
            }

            Console.Write((string.Join("\n", chat)));
        }
    }
}
