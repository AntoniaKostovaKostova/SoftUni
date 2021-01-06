using System;

namespace Ex03NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double flowerPrice = 0.0;
            double moneyNeed = 0.0;
            double moneyLeft = 0.0;
            double moneyMore = 0.0;
            double discount = 0.0;
            double overPrice = 0.0;

            if (flower == "Roses")
            {
                flowerPrice = 5;

                if (flowerCount > 80)
                {
                    discount = 0.1;
                }
            }
            else if (flower == "Dahlias")
            {
                flowerPrice = 3.80;

                if (flowerCount > 90)
                {
                    discount = 0.15;
                }
            }
            else if (flower == "Tulips")
            {
                flowerPrice = 2.80;

                if (flowerCount > 80)
                {
                    discount = 0.15;
                }
            }
            else if (flower == "Narcissus")
            {
                flowerPrice = 3;

                if (flowerCount < 120)
                {
                    overPrice = 0.15;
                }
            }
            else if (flower == "Gladiolus")
            {
                flowerPrice = 2.50;

                if (flowerCount < 80)
                {
                    overPrice = 0.2;
                }
            }

            moneyNeed = (flowerCount * flowerPrice) - ((flowerCount * flowerPrice) * discount) + ((flowerCount * flowerPrice)*overPrice);
            moneyLeft = budget - moneyNeed;
            moneyMore = moneyNeed - budget;

         


            if (moneyLeft >= 0)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flower} and {moneyLeft:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {moneyMore:F2} leva more.");
            }
        }
    }
}
