using System;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberriesPrice = double.Parse(Console.ReadLine());
            double bananasWeight = double.Parse(Console.ReadLine());
            double orangesWeight = double.Parse(Console.ReadLine());
            double raspberriesWeight = double.Parse(Console.ReadLine());
            double strawberriesWeight = double.Parse(Console.ReadLine());

            double raspberriesPrice = strawberriesPrice / 2;
            double orangesPrice = raspberriesPrice - raspberriesPrice * 40 * 0.01;
            double bananasPrice = raspberriesPrice - raspberriesPrice * 80 * 0.01;

            double sumMoney = strawberriesWeight * strawberriesPrice + bananasWeight * bananasPrice + orangesWeight * orangesPrice + raspberriesWeight * raspberriesPrice;
            Console.WriteLine(sumMoney);
        }
    }
}
