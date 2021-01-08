using System;
using System.Reflection;

namespace Ex05DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            for (int i = 1; i <= count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    p1++;
                }
                if (number % 3 == 0)
                {
                    p2++;
                }
                if (number % 4 == 0)
                {
                    p3++;
                }
            }
            Console.WriteLine($"{(1.0 * p1/count) * 100:F2}%");
            Console.WriteLine($"{(1.0 * p2/count) * 100:F2}%");
            Console.WriteLine($"{(1.0 * p3/count) * 100:F2}%");
        }
    }
}
