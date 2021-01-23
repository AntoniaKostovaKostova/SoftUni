using System;

namespace Ex02PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pound = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"{pound * 1.31M:F3}");
        }
    }
}
