using System;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double hallMoney = double.Parse(Console.ReadLine());
            double cake = hallMoney * 20 * 0.01;
            double drinks = cake - (45 * 0.01 * cake);
            double animator = hallMoney / 3;
            double sum = hallMoney + cake + drinks + animator;
            Console.WriteLine(sum);
        }
    }
}