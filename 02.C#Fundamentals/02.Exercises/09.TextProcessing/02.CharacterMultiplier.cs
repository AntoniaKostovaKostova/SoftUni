using System;

namespace Ex02CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int firstCount = input[0].Length;
            int secondCount = input[1].Length;

            long result = 0;

            if (firstCount == secondCount)
            {
                for (int i = 0; i < firstCount; i++)
                {
                    result += input[0][i] * input[1][i];
                }
            }

            if (firstCount > secondCount)
            {
                for (int i = 0; i < secondCount; i++)
                {
                    result += input[0][i] * input[1][i];
                }
                for (int j = secondCount; j < firstCount; j++)
                {
                    result += input[0][j];
                }
            }

            else if (secondCount > firstCount)
            {
                for (int i = 0; i < firstCount; i++)
                {
                    result += input[0][i] * input[1][i];
                }
                for (int j = firstCount; j < secondCount; j++)
                {
                    result += input[1][j];
                }
            }
            Console.WriteLine(result);
        }
    }
}
