using System;
using System.Runtime.InteropServices;

namespace Ex01.Problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            int biscuitsPerWorkerPerDay = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());

            int amountPerMonthOtherFactory = int.Parse(Console.ReadLine());

            int amountPerMonth = 0;
            double percentageDifference = 0;

            int amountPerUsualDay = biscuitsPerWorkerPerDay * workersCount;
            double amountEveryThirdDay = Math.Floor(biscuitsPerWorkerPerDay * workersCount * 0.75);

            amountPerMonth = (20 * amountPerUsualDay) + (int)(10 * amountEveryThirdDay);

            Console.WriteLine($"You have produced {amountPerMonth} biscuits for the past month.");

            double onePercent = (double)amountPerMonthOtherFactory / (double)100;

            percentageDifference = Math.Abs((double)(amountPerMonth - amountPerMonthOtherFactory) / (double)onePercent);

            if (amountPerMonth > amountPerMonthOtherFactory)
            {
                Console.WriteLine($"You produce {percentageDifference:F2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {percentageDifference:F2} percent less biscuits.");
            }
        }
    }
}
