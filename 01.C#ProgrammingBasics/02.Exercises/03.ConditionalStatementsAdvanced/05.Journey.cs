using System;

namespace Ex05Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string excursionType = "";
            double moneySpend = 0.0;

            if (budget <= 100)
            {
                destination = "Bulgaria";

                if (season == "summer")
                {
                    moneySpend = budget * 0.3;
                    excursionType = "Camp";
                }
                else if (season == "winter")
                {
                    moneySpend = budget * 0.7;
                    excursionType = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";

                if (season == "summer")
                {
                    moneySpend = budget * 0.4;
                    excursionType = "Camp";
                }
                else if (season == "winter")
                {
                    moneySpend = budget * 0.8;
                    excursionType = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                moneySpend = budget * 0.9;
                excursionType = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{excursionType} - {moneySpend:F2}");

        }
    }
}
