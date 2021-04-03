using System;
using System.Text.RegularExpressions;

namespace Ex02Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int successfulRegCount = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Regex pattern = new Regex(@"[U][$]([A-Z][a-z][a-z]+)[U][$][P][@][$]([[A-Za-z]{5}[A-Za-z]*[0-9]+)[P][@][$]");

                Match match = pattern.Match(input);

                string name = match.Groups[1].Value;
                string password = match.Groups[2].Value;

                if (name.Length > 0 && password.Length > 0)
                {
                    successfulRegCount++;
                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {name}, Password: {password}");
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
               
            }
            Console.WriteLine($"Successful registrations: {successfulRegCount}");
        }
    }
}
