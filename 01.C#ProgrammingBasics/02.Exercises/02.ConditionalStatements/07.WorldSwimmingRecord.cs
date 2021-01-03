using System;

namespace Ex07WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal worldRecord = decimal.Parse(Console.ReadLine()); //10464
            decimal distance = decimal.Parse(Console.ReadLine()); //1500
            decimal SecondsForMeter = decimal.Parse(Console.ReadLine()); //20

            decimal timeNoSlow = distance * SecondsForMeter;

            int slowTimes = (int)(distance / 15);
            //slowTimes = Math.Floor(slowTimes);

            decimal slowSeconds = slowTimes * 12.5m;
            decimal finalTime = timeNoSlow + slowSeconds;
            decimal timeDifference = worldRecord - finalTime;

            if (timeDifference > 0)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {finalTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {-(timeDifference):F2} seconds slower.");
            }
        }
    }
}
