using System;

namespace Ex05Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";
            int counter = 0;
            bool isBloked = false;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password = password + username[i];
            }

            while (isBloked == false && password != Console.ReadLine())
            {
                counter++;
                if (counter > 3)
                {
                    isBloked = true;
                    Console.WriteLine($"User {username} blocked!");
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
            if (isBloked == false && (password != Console.ReadLine()))
            {
                Console.WriteLine($"User {username} logged in.");
            }

        }
    }
}
