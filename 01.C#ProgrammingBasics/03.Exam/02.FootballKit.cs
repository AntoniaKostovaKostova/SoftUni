using System;

namespace Ex02FootballKit
{
    class Program
    {
        static void Main(string[] args)
        {
            double shirt = double.Parse(Console.ReadLine());
            double sumNeeded = double.Parse(Console.ReadLine());

            double shorts = shirt * 0.75;
            double socks = shorts * 0.2;
            double buttons = 2 * (shirt + shorts);

            double sum = (shirt + shorts + socks + buttons) * 0.85;
            if (sum>=sumNeeded)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {sum:f2} lv.");
            }
            else 
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {sumNeeded-sum:f2} lv. more.");
            }
            
        }
    }
}
