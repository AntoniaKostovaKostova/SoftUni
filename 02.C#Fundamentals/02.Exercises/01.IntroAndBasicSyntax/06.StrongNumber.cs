using System;

namespace Ex06StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int actualNumber = number;

            int sum = 0;
            string lenght = number.ToString();
            int digitCount = lenght.Length;
            for (int j = digitCount; j >= 1; j--)
            {
                int digit = number % 10;
                int factorial = 1;
                for (int i = digit; i >= 1; i--)
                {
                    factorial = factorial * i;
                }
                sum += factorial;
                number = number / 10;
            }
            if (actualNumber == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
