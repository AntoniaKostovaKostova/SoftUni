using System;

namespace Ex06PassengersPerFlight
{
    class Program
    {
        static void Main(string[] args)
        {
            int companiesCount = int.Parse(Console.ReadLine());
            double maxScore = 0;
            string winInput = "";

            for (int i = 1; i <= companiesCount; i++)
            {
                int passangerCount = 0;
                int counterFlights = 0;
                string input = Console.ReadLine();
                string inputPassangers = Console.ReadLine();

                while (inputPassangers != "Finish")
                {
                    passangerCount += int.Parse(inputPassangers);
                    counterFlights++;
                    inputPassangers = Console.ReadLine();
                }

                double average = Math.Floor((1.0 * passangerCount) / (1.0 * counterFlights));
                Console.WriteLine($"{input}: {average} passengers.");
                if (average > maxScore)
                {
                    maxScore = average;
                    winInput = input;
                }

            }

            Console.WriteLine($"{winInput} has most passengers per flight: {maxScore}");
        }

    }
}

