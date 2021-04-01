using System;

namespace Ex01ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string instruction = Console.ReadLine();

            while (instruction != "Generate")
            {

                string[] commands = instruction.Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                if (commands[0] == "Contains")
                {
                    if (activationKey.Contains(commands[1]))
                    {
                        Console.WriteLine($"{activationKey} contains {commands[1]}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }

                else if (commands[0] == "Flip")
                {
                    string upperOrLower = commands[1];
                    int startIndex = int.Parse(commands[2]);
                    int endIndex = int.Parse(commands[3]);

                    string substring = activationKey.Substring(startIndex, endIndex - startIndex);
                    string changedSubstring = string.Empty;

                    if (upperOrLower == "Upper")
                    {
                        changedSubstring = substring.ToUpper();
                    }
                    else
                    {
                        changedSubstring = substring.ToLower();
                    }
                    activationKey = activationKey.Replace(substring, changedSubstring);//

                    Console.WriteLine($"{activationKey}");
                }

                else if (commands[0] == "Slice")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);

                    activationKey = activationKey.Remove(startIndex, endIndex - startIndex);//
                    Console.WriteLine($"{activationKey}");
                }

                instruction = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
