using System;

namespace Ex03SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sumPrime = 0;
            int sumNonPrime = 0;
            while (input != "stop")
            {
                int number = int.Parse(input);

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    bool isPrime = true;
                    for (int i = number - 1; i > 1; i--)
                    {
                        if (number % i == 0)
                        {
                            sumNonPrime += number;
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        sumPrime += number;
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
