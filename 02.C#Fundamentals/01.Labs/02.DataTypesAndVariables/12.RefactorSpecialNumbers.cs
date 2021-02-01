using System;

namespace Ex12RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int integerN = int.Parse(Console.ReadLine());
            for (int i = 1; i <= integerN; i++)
            {
                int sum = 0;
                int number = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                bool isSpecialNum = false;
                isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", number, isSpecialNum);
                sum = 0;
                i = number;
            }

        }
    }
}
