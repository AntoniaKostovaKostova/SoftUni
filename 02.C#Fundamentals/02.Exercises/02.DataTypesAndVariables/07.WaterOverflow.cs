using System;

namespace Ex07WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = 0;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if (capacity +liters <= 255)
                {
                    capacity += liters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(capacity);
        }
    }
}
