using System;

namespace Ex02Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string password = Console.ReadLine();
            string tryPassword = "";
            while (tryPassword != password)
            {
                tryPassword = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {name}!");
        }
    }
}
