using System;
using System.Numerics;

namespace Ex11Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger snowballValue = 0;
            BigInteger value = 0;
            int snow = 0;
            int time = 0;
            int quality = 0;

            int snowballSnow = 0;
            int snowballTime = 0;
            int snowballQuality = 0;
            for (int i = 1; i <= n; i++)
            {
                snowballSnow = int.Parse(Console.ReadLine());
                snowballTime = int.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());
                snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                if (value < snowballValue)
                {
                    value = snowballValue;
                    snow = snowballSnow;
                    time = snowballTime;
                    quality = snowballQuality;
                }
            }
            Console.WriteLine($"{snow} : {time} = {value} ({quality})");
        }
    }
}
