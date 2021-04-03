using System;
using System.Collections.Generic;

namespace Ex01Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Complete")
            {

                if (command == "Make Upper")
                {
                    email = email.ToUpper();

                    Console.WriteLine($"{email}");
                }

                else if (command == "Make Lower")
                {
                    email = email.ToLower();

                    Console.WriteLine($"{email}");
                }

                else if (command.Contains("GetDomain"))
                {
                    string[] comm = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    var domain = email.Substring(email.Length - int.Parse(comm[1]), int.Parse(comm[1]));

                    Console.WriteLine($"{domain}");
                }

                else if (command == "GetUsername")
                {
                    int index = email.IndexOf("@");

                    if (index > -1)
                    {
                        string substring = email.Substring(0, index);
                        Console.WriteLine($"{substring}");
                    }
                    else
                    {
                        Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                    }

                }

                else if (command.Contains("Replace"))
                {
                    string[] replacement = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    string newEmail = email.Replace(replacement[1], "-");
                    Console.WriteLine($"{newEmail}");
                }

                else if (command == "Encrypt")
                {
                    List<int> encripted = new List<int>();

                    foreach (var character in email)
                    {
                        encripted.Add(character);
                    }

                    Console.WriteLine(string.Join(" ", encripted));
                }


                command = Console.ReadLine();
            }
        }
    }
}
