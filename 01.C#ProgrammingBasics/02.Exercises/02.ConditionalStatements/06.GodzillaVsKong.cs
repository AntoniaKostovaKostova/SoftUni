using System;

namespace Ex03GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyAvailable = double.Parse(Console.ReadLine());
            int actors = int.Parse(Console.ReadLine());
            double clothesPerActorPrice = double.Parse(Console.ReadLine());

            double decor = moneyAvailable * 0.10;
            double moneyForClothes;
            double moneyNeeded;
           

            if (actors>150)
            {
                clothesPerActorPrice = clothesPerActorPrice - clothesPerActorPrice * 0.10;
                moneyForClothes = clothesPerActorPrice * actors;
            }
            else
            {
                moneyForClothes = clothesPerActorPrice * actors;
            }

            moneyNeeded = moneyForClothes + decor;

            if (moneyNeeded > moneyAvailable)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {(moneyNeeded-moneyAvailable):F2} leva more.");
            }
            else 
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(moneyAvailable-moneyNeeded):F2} leva left.");
            }
        }
    }
}
