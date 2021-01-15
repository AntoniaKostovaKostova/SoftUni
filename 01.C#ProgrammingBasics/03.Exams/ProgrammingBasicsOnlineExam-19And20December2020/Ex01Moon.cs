using System;

namespace Ex01Moon
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
            double fuelPerHundredKilometers = double.Parse(Console.ReadLine());
            double distance = 384400;

            double distanceInTwoDirections = distance * 2;

            double hours = Math.Ceiling(distanceInTwoDirections / speed) + 3;

            double sumFuel = ((distance * 2) * fuelPerHundredKilometers) / 100;


            Console.WriteLine(hours);
            Console.WriteLine(Math.Ceiling(sumFuel));

        }
    }
}
