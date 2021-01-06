using System;

namespace Ex07HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double priceForApartment = 0.0;
            double priceForStudio = 0.0;

            if (month == "May" || month == "October")
            {
                priceForStudio = 50;
                priceForApartment = 65;
                if (nights > 7 && nights < 14)
                {
                    priceForStudio = priceForStudio - priceForStudio * 0.05;
                }
                else if (nights > 14)
                {
                    priceForStudio = priceForStudio - priceForStudio * 0.30;
                }
            }
            else if (month == "June" || month == "September")
            {
                priceForStudio = 75.20;
                priceForApartment = 68.70;
                if (nights > 14)
                {
                    priceForStudio = priceForStudio - priceForStudio * 0.20;
                }
            }
            else if (month == "July" || month == "August")
            {
                priceForStudio = 76;
                priceForApartment = 77;
            }
            if (nights > 14)
            {
                priceForApartment = priceForApartment - priceForApartment * 0.10;
            }
            Console.WriteLine($"Apartment: {nights * priceForApartment:F2} lv.");
            Console.WriteLine($"Studio: {nights * priceForStudio:F2} lv.");          
        }
    }
}
