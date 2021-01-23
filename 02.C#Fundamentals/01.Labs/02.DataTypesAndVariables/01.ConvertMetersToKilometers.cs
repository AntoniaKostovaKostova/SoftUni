using System;

namespace Ex01ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal meters = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"{meters / 1000M:F2}");
        }
    }
}
