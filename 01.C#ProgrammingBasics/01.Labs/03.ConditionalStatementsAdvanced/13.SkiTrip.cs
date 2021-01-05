using System;
using System.Threading;

namespace Ex12TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string opinion = Console.ReadLine();

            int nights = days - 1;

            double roomTypePrice = 0;
            double discount = 0;
            double moneyToOpinion = 0;

            double moneyToPay = 0;// roomTypePrice * nights;

            switch (roomType)
            {
                case "room for one person":
                    roomTypePrice = 18;
                    moneyToPay = roomTypePrice * nights;
                    break;

                case "apartment":
                    roomTypePrice = 25;
                    if (days < 10)
                    {
                        discount = 0.30;
                        moneyToPay = (roomTypePrice * nights) - (roomTypePrice * nights) * discount;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        discount = 0.35;
                        moneyToPay = (roomTypePrice * nights) - (roomTypePrice * nights) * discount;
                    }
                    else if (days > 15)
                    {
                        discount = 0.50;
                        moneyToPay = (roomTypePrice * nights) - (roomTypePrice * nights) * discount;
                    }
                    break;

                case "president apartment":
                    roomTypePrice = 35;
                    if (days < 10)
                    {
                        discount = 0.10;
                        moneyToPay = (roomTypePrice * nights) - (roomTypePrice * nights) * discount;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        discount = 0.15;
                        moneyToPay = (roomTypePrice * nights) - (roomTypePrice * nights) * discount;
                    }
                    else if (days > 15)
                    {
                        discount = 0.20;
                        moneyToPay = (roomTypePrice * nights) - (roomTypePrice * nights) * discount;
                    }
                    break;
            }
            if (opinion == "positive")
            {
                moneyToOpinion = 0.25;
                moneyToPay = moneyToPay + moneyToPay * moneyToOpinion;
            }
            else if (opinion == "negative")
            {
                moneyToOpinion = 0.10;
                moneyToPay = moneyToPay - moneyToPay * moneyToOpinion;
            }
            Console.WriteLine($"{moneyToPay:F2}");
        }
       
    }
}
