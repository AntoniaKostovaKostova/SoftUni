using System;

namespace Ex12TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sold = double.Parse(Console.ReadLine());

            double commission = 0;

            bool error = false;
            switch (city)
            {
                case "Sofia":
                    if (sold >= 0 && sold <= 500 )
                    {
                        commission = 0.05;
                    }
                    else if (sold > 500 && sold <= 1000)
                    {
                        commission = 0.07;
                    }
                    else if (sold > 1000 && sold <= 10000)
                    {
                        commission = 0.08;
                    }
                    else if (sold >10000)
                    {
                        commission = 0.12;
                    }
                    else
                    {
                        error = true;
                    }
                    break;
                case "Varna":
                    if (sold >= 0 && sold <= 500)
                    {
                        commission = 0.045;
                    }
                    else if (sold > 500 && sold <= 1000)
                    {
                        commission = 0.075;
                    }
                    else if (sold > 1000 && sold <= 10000)
                    {
                        commission = 0.1;
                    }
                    else if (sold > 10000)
                    {
                        commission = 0.13;
                    }
                    else
                    {
                        error = true;
                    }
                    break;
                case "Plovdiv":
                    if (sold >= 0 && sold <= 500)
                    {
                        commission = 0.055;
                    }
                    else if (sold > 500 && sold <= 1000)
                    {
                        commission = 0.08;
                    }
                    else if (sold > 1000 && sold <= 10000)
                    {
                        commission = 0.12;
                    }
                    else if (sold > 10000)
                    {
                        commission = 0.145;
                    }
                    else
                    {
                        error = true;
                    }
                    break;
                default:
                    error = true;
                    break;
            }

            if (error)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{(commission * sold):F2}");
            }
        }
    }
}
