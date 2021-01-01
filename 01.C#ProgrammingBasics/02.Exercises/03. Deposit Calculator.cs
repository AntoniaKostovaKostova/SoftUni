using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());
            double yearPercent =double.Parse(Console.ReadLine());

            double sum = deposit + time * ((deposit * yearPercent*0.01) / 12);
            Console.WriteLine(sum);
        }
    }
}
