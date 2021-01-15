using System;

namespace Ex04ComputerFirm
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double allSold = 0;
            double allRate = 0;
            for (int i = 1; i <= count; i++)
            {
                double rate = 0;
                double sold = 0;
                double percent = 0;
                int number = int.Parse(Console.ReadLine());
                rate = number % 10;
                sold = number / 10;

                if (rate==2)
                {
                    percent = 0;
                    sold = sold * percent;
                }
                else if (rate == 3)
                {
                    percent = 0.5;
                    sold = sold * percent;
                }
                else if (rate == 4)
                {
                    percent = 0.7;
                    sold = sold * percent;
                }
                else if (rate == 5)
                {
                    percent = 0.85;
                    sold = sold * percent;
                }
                else if (rate == 6)
                {
                    percent = 1;
                    sold = sold * percent;
                }
                allSold += sold;
                allRate += rate;
            }
            Console.WriteLine($"{allSold:f2}");
            Console.WriteLine($"{allRate/count:f2}");

        }
    }
}
