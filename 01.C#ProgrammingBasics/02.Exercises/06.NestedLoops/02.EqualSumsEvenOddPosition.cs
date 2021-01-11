using System;

namespace Ex02EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                int evenSum = 0;
                int oddSum = 0;

                string iString = $"{i}";

                for (int index = 0; index < 6; index += 2)
                {
                    int number = int.Parse(iString[index].ToString());
                    evenSum += number;
                }
                for (int index = 1; index < 6; index += 2)
                {
                    int number = int.Parse(iString[index].ToString());
                    oddSum += number;
                }
                if (evenSum == oddSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
