using System;

namespace Ex05ExcursionSale
{
    class Program
    {
        static void Main(string[] args)
        {
            int seaCount = int.Parse(Console.ReadLine());
            int mountainCount = int.Parse(Console.ReadLine());
            int counter = 0;
            int seaCounter = 0;
            int mountainCounter = 0;
            int profit = 0;

            string command = Console.ReadLine();
            while (command != "Stop")
            {

                if (command == "sea")
                {
                    if (seaCount > seaCounter)
                    {
                        seaCounter++;
                        profit += 680;
                        counter++;
                    }
                }
                else if (command == "mountain")
                {
                    if (mountainCount > mountainCounter)
                    {
                        mountainCounter++;
                        profit += 499;
                        counter++;
                    }
                }

                if (seaCount + mountainCount > counter)
                {
                    command = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Good job! Everything is sold.");
                    break;
                }
            }
            Console.WriteLine($"Profit: {profit} leva.");
        }
    }
}
