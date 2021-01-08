using System;

namespace Ex03OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            double count = double.Parse(Console.ReadLine());
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double oddSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            double evenSum = 0;

            for (int i = 1; i <= count; i++)
            {
                double n = double.Parse(Console.ReadLine());
                if (!(i % 2 == 0))
                {
                    oddSum += n;
                    if (n > oddMax)
                    {
                        oddMax = n;
                    }
                    if (n < oddMin)
                    {
                        oddMin = n;
                    }
                }
                else
                {
                    evenSum += n;
                    if (n > evenMax)
                    {
                        evenMax = n;
                    }
                    if (n < evenMin)
                    {
                        evenMin = n;
                    }
                }

            }
            Console.WriteLine($"OddSum={oddSum:F2},");
            if (oddMax == double.MinValue || oddMin == double.MaxValue)
            {
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:F2},");
                Console.WriteLine($"OddMax={oddMax:F2},");
            }
            Console.WriteLine($"EvenSum={evenSum:F2},");
            if (evenMax == double.MinValue || evenMin == double.MaxValue)
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:F2},");
                Console.WriteLine($"EvenMax={evenMax:F2}");
            }
        }
    }
}
