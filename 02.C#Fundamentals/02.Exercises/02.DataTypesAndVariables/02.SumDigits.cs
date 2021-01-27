using System;

namespace Ex02SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            long sum = 0;
            bool isEnd = false;

            while (!isEnd)
            {
                if (number > 0)
                {
                    sum += number % 10;
                    number = number / 10;
                }
                else
                {
                    isEnd = true;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
