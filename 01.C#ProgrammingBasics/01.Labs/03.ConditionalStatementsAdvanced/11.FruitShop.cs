using System;

namespace Ex11FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double bananaPrice = 0;
            double applePrice = 0;
            double orangePrice = 0;
            double grapefruitPrice = 0;
            double kiwiPrice = 0;
            double pineapplePrice = 0;
            double grapesPrice = 0;

            double finalPrice = 0;

            bool error = false;
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    bananaPrice = 2.50;
                    applePrice = 1.20;
                    orangePrice = 0.85;
                    grapefruitPrice = 1.45;
                    kiwiPrice = 2.70;
                    pineapplePrice = 5.50;
                    grapesPrice = 3.85;
                    break;
                case "Saturday":
                case "Sunday":
                    bananaPrice = 2.70;
                    applePrice = 1.25;
                    orangePrice = 0.90;
                    grapefruitPrice = 1.60;
                    kiwiPrice = 3.00;
                    pineapplePrice = 5.60;
                    grapesPrice = 4.20;
                    break;

                default:
                    error = true;
                    break;
            }

            switch (fruit)
            {
                case "banana":
                    finalPrice = bananaPrice * quantity;
                    break;
                case "apple":
                    finalPrice = applePrice * quantity;
                    break;
                case "orange":
                    finalPrice = orangePrice * quantity;
                    break;
                case "grapefruit":
                    finalPrice = grapefruitPrice * quantity;
                    break;
                case "kiwi":
                    finalPrice = kiwiPrice * quantity;
                    break;
                case "pineapple":
                    finalPrice = pineapplePrice * quantity;
                    break;
                case "grapes":
                    finalPrice = grapesPrice * quantity;
                    break;
                default:
                    error = true;
                    break;
            }

            if (error)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{finalPrice:F2}");
            }
        }
    }
}
