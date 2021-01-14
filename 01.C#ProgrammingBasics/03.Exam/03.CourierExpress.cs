using System;
using System.ComponentModel.Design;

namespace Ex03CourierExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int km = int.Parse(Console.ReadLine());

            double price = 0;
            double overPrice = 0;

            switch (type)
            {
                case "standard":
                    if (weight < 1)
                    {
                        price = km * 3;
                    }
                    else if (weight >= 1 && weight < 10)
                    {
                        price = km * 5;
                    }
                    else if (weight >= 10 && weight < 40)
                    {
                        price = km * 10;
                    }
                    else if (weight >= 40 && weight < 90)
                    {
                        price = km * 15;
                    }
                    else if (weight >= 90 && weight < 150)
                    {
                        price = km * 20;
                    }
                    break;

                case "express":
                    if (weight < 1)
                    {
                        overPrice = 0.8 * 3 * km * weight;
                        price = km * 3 + overPrice;
                    }
                    else if (weight >= 1 && weight < 10)
                    {
                        overPrice = 0.4 * 5 * km * weight;
                        price = km * 5 + overPrice;
                    }
                    else if (weight >= 10 && weight < 40)
                    {
                        overPrice = 0.05 * 10 * km * weight;
                        price = km * 10 + overPrice;
                    }
                    else if (weight >= 40 && weight < 90)
                    {
                        overPrice = 0.02 * 15 * km * weight;
                        price = km * 15 + overPrice;
                    }
                    else if (weight >= 90 && weight < 150)
                    {
                        overPrice = 0.01 * 20 * km * weight;
                        price = km * 20 + overPrice;
                    }
                    break;
            }

            Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {price / 100:f2} lv.");

        }
    }
}
