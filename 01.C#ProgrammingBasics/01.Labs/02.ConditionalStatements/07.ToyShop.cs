using System;
using System.Data.SqlTypes;

namespace Ex07ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double excursionPrice = double.Parse(Console.ReadLine());
            int puzzels = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int teddies = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double puzzelsPrice = puzzels * 2.60;
            double dollsPrice = dolls * 3.0;
            double teddiesPrice = teddies * 4.10;
            double minionsPrice = minions * 8.20;
            double trucksPrice = trucks * 2.0;

            double moneyForToys = puzzelsPrice + dollsPrice + teddiesPrice + minionsPrice + trucksPrice;

            double numberToys = puzzels + dolls + teddies + minions + trucks;

            double discount;
            double moneyWithDiscount;
            double moneyAfterRentPayment;
            if (numberToys >= 50)
            {
                discount = moneyForToys * 0.25;
                moneyWithDiscount = moneyForToys - discount;
                moneyAfterRentPayment = moneyWithDiscount - moneyWithDiscount * 0.1;
            }
            else
            {
                moneyAfterRentPayment = moneyForToys - moneyForToys * 0.1;
            }
                
            if (moneyAfterRentPayment >= excursionPrice)
            {
               Console.WriteLine($"Yes! {(moneyAfterRentPayment - excursionPrice):F2} lv left.");
            }
            else
            {
               Console.WriteLine($"Not enough money! {(excursionPrice - moneyAfterRentPayment):F2} lv needed.");
            }            
        }
    }
}
