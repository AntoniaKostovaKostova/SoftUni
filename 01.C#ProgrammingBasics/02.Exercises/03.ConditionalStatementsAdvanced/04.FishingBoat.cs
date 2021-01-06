using System;

namespace Ex04FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            double shipPrice = 0.0;
            double discount = 0.0;
            double extraDiscount = 0.0;
            double moneyNeed = 0.0;

            switch (season)
            {
                case "Spring":
                    shipPrice = 3000;
                    if (fishermen % 2 == 0)
                    {
                        extraDiscount = 0.05;
                    }
                    break;
                case "Summer":
                    shipPrice = 4200;
                    if (fishermen % 2 == 0)
                    {
                        extraDiscount = 0.05;
                    }
                    break;
                case "Autumn":
                    shipPrice = 4200;
                    break;
                case "Winter":
                    shipPrice = 2600;
                    if (fishermen % 2 == 0)
                    {
                        extraDiscount = 0.05;
                    }
                    break;
            }

            if (fishermen < 7)
            {
                discount = 0.1;
            }
            else if (fishermen >=7 && fishermen <= 11 )
            {
                discount = 0.15;
            }
            else if (fishermen >= 12)
            {
                discount = 0.25;
            }

            moneyNeed = shipPrice - (shipPrice * discount);
            moneyNeed = (moneyNeed - (moneyNeed * extraDiscount));

            if ((budget - moneyNeed) >= 0)
            {
                Console.WriteLine($"Yes! You have {budget - moneyNeed:F2} leva left.");
            }
            else if ((budget - moneyNeed) < 0)
            {
                Console.WriteLine($"Not enough money! You need {-(budget - moneyNeed):F2} leva.");
            }
        }
    }
}
