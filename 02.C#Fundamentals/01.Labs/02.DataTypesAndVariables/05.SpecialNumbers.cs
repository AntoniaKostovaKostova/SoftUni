using System;

namespace Ex05SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int result = 0;
                int k = i;
                while (k > 0)
                {
                    result += k % 10;
                    k /= 10;
                }

                if (result == 5 || result == 7 || result == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
