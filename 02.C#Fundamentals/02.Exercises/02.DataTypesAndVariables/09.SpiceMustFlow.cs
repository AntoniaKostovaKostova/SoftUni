using System;

namespace Ex09SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            long yield = int.Parse(Console.ReadLine());
            int days = 0;
            long totalAmount = 0;

            if (yield < 100)
            {
                Console.WriteLine(0);
                Console.WriteLine(0);
                return;
            }
            while (yield >= 100)
            {
                totalAmount += yield;
                totalAmount -= 26;
                days++;
                yield -= 10;
            }
            totalAmount -= 26;
            Console.WriteLine(days);
            Console.WriteLine(totalAmount);
        }
    }
}
