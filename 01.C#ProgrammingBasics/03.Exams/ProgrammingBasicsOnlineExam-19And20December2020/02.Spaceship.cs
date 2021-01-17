using System;

namespace Ex02Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double widthShip = double.Parse(Console.ReadLine());
            double lengthShip = double.Parse(Console.ReadLine());
            double heightShip = double.Parse(Console.ReadLine());
            double averageHAutronafts = double.Parse(Console.ReadLine());

            double volume = 0;
            double oneRoom = 0;
            double astronauts = 0;

            oneRoom = 2 * 2 * (averageHAutronafts + 0.40);
            volume = widthShip * lengthShip * heightShip;

            astronauts = Math.Floor(volume / oneRoom);

            if (astronauts >= 3 && astronauts <= 10)
            {
                Console.WriteLine($"The spacecraft holds {astronauts} astronauts.");
            }
            else if (astronauts < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (astronauts > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}
