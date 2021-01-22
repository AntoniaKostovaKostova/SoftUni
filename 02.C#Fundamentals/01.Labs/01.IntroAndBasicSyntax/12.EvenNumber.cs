using System;

namespace Ex12EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isEnd = false;
            while (!isEnd)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 != 0)
                {
                    Console.WriteLine("Please write an even number.");
                }
                else
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                    isEnd = true;
                }
            }
        }
    }
}
