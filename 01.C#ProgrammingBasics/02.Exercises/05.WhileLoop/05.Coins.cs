using System;
using System.Transactions;

namespace Ex05Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double cashback = double.Parse(Console.ReadLine());
            int counterCoins = 0;
            double oneCoin = 0.01d;
            double twoCoin = 0.02d;
            double fiveCoin = 0.05d;
            double tenCoin = 0.10d;
            double twentyCoin = 0.20d;
            double fiftyCoin = 0.50d;
            double oneBigCoin = 1.00d;
            double twoBigCoin = 2.00d;
            while (cashback - twoBigCoin >= 0)
            {
                counterCoins++;
                cashback -= twoBigCoin;
                cashback=Math.Round(cashback, 2);              
            }
            while (cashback - oneBigCoin >= 0)
            {
                counterCoins++;
                cashback -= oneBigCoin;
                cashback = Math.Round(cashback, 2);
            }
            while (cashback - fiftyCoin >= 0)
            {
                counterCoins++;
                cashback -= fiftyCoin;
                cashback = Math.Round(cashback, 2);
            }
            while (cashback - twentyCoin >= 0)
            {
                counterCoins++;
                cashback -= twentyCoin;
                cashback = Math.Round(cashback, 2);
            }
            while (cashback - tenCoin >= 0)
            {
                counterCoins++;
                cashback -= tenCoin;
                cashback = Math.Round(cashback, 2);
            }
            while (cashback - fiveCoin >= 0)
            {
                counterCoins++;
                cashback -= fiveCoin;
                cashback = Math.Round(cashback, 2);
            }
            while (cashback - twoCoin >= 0)
            {
                counterCoins++;
                cashback -= twoCoin;
                cashback = Math.Round(cashback, 2);
            }
            while (cashback - oneCoin >= 0)
            {
                counterCoins++;
                cashback -= oneCoin;
                cashback = Math.Round(cashback, 2);
            }
            if (cashback < 0.01)
            {
                Console.WriteLine(counterCoins);
            }
        }
    }
}

