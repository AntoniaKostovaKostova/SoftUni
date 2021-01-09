using System;

namespace Ex05AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string income = (Console.ReadLine());
            double sum = 0;

            while (income != "NoMoreMoney")
            {
                double doubleIncome = double.Parse(income);
                if (doubleIncome < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    Console.WriteLine($"Total: {sum:F2}");
                    break;
                }
                else
                {
                    Console.WriteLine($"Increase: {doubleIncome:F2}");
                }
                income = (Console.ReadLine());
                sum = sum + doubleIncome;
            }
            if (income == "NoMoreMoney")
            {
                Console.WriteLine($"Total: {sum:F2}");
            }
        }
    }
}
