using System;

namespace Ex08NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int num = 0;
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 1; i <= count; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (num < min)
                {
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }
    }
}
