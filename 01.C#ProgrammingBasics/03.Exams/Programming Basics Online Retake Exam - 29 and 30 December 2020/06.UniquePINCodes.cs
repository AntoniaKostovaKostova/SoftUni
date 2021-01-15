using System;

namespace Ex06UniquePINCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int upperFirst = int.Parse(Console.ReadLine());
            int upperSecond = int.Parse(Console.ReadLine());
            int upperThird = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= upperFirst; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 1; j <= upperSecond; j++)
                    {
                        if (j >= 2 && j <= 7)
                        {
                            if (j == 2 || j % 2 != 0)
                            {
                                for (int k = 1; k <= upperThird; k++)
                                {
                                    if (k % 2 == 0)
                                    {
                                        Console.WriteLine($"{i} {j} {k}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
