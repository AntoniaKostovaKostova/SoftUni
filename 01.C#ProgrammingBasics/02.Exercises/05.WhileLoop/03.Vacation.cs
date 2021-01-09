using System;
using System.Diagnostics;

namespace Ex03Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double excursionPrice = double.Parse(Console.ReadLine());
            double moneySaved = double.Parse(Console.ReadLine());
            int counterSpend = 0;
            int counterDays = 0;
            while (moneySaved < excursionPrice)
            {
                counterDays++;
                string spendOrSave = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());                

                if (spendOrSave == "save")
                {
                    counterSpend = 0;
                    moneySaved += money;
                }
                else if (spendOrSave == "spend")
                {
                    counterSpend++;
                    if (money > moneySaved)
                    {
                        moneySaved = 0;
                    }
                    else
                    {
                        moneySaved -= money;
                    }
                }             
                if (counterSpend == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(counterDays);
                    break;
                }
                
            }
            if (moneySaved >= excursionPrice)
            {
                Console.WriteLine($"You saved the money for {counterDays} days.");
            }
        }
    }
}
