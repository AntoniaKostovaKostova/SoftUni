using System;

namespace Ex11CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            double sum = 0;
            double leftSum = 0;
            double needSum = 0;
            int evenBirthday = age / 2;
            int oddBirthday = age - evenBirthday;
            int toys = oddBirthday;
            for (int i = 1; i <= evenBirthday; i++)
            {
                sum += i * 10;
                sum--;
            }

            sum = sum + toys * toyPrice;
            leftSum = sum - price;
            needSum = price - sum;
            if (price <= sum)
            {
                Console.WriteLine($"Yes! {leftSum:F2}");
            }
            else
            {
                Console.WriteLine($"No! {needSum:F2}");
            }
        }
    }
}
