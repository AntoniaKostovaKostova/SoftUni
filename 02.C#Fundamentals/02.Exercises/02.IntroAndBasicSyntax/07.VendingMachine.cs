using System;
using System.Runtime.CompilerServices;

namespace Ex07VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;
            while (input != "Start")
            {
                double money = double.Parse(input);
                if (money == 0.1 || money == 0.2 || money == 0.5 || money == 1 || money == 2)
                {
                    sum += money;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {money}");
                }
                input = Console.ReadLine();
            }
            string line = Console.ReadLine();
            double price = 0;
            while (line != "End")
            {
                if (line == "Nuts")
                {
                    price = 2;
                    if (price <= sum)
                    {
                        Console.WriteLine($"Purchased {line.ToLower()}");
                        sum -= price;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (line == "Water")
                {
                    price = 0.7;
                    if (price <= sum)
                    {
                        Console.WriteLine($"Purchased {line.ToLower()}");
                        sum -= price;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (line == "Crisps")
                {
                    price = 1.5;
                    if (price <= sum)
                    {
                        Console.WriteLine($"Purchased {line.ToLower()}");
                        sum -= price;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (line == "Soda")
                {
                    price = 0.8;
                    if (price <= sum)
                    {
                        Console.WriteLine($"Purchased {line.ToLower()}");
                        sum -= price;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (line == "Coke")
                {
                    price = 1;
                    if (price <= sum)
                    {
                        Console.WriteLine($"Purchased {line.ToLower()}");
                        sum -= price;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                line = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:F2}");
        }
    }
}
