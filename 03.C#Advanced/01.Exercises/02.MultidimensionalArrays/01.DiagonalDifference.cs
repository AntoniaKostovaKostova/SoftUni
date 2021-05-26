using System;
using System.Linq;

namespace _01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] squareMatrix = new int[n, n];

            int mainDiagonal = 0;
            int secondaryDiagonal = 0;
            int result = 0;

            for (int row = 0; row < n; row++)
            {
                int[] number = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    squareMatrix[row, col] = number[col];

                    if (row == col)
                    {
                        mainDiagonal += number[col];
                    }
                    if (n - 1 == Math.Abs(row + col))
                    {
                        secondaryDiagonal += number[col];
                    }
                }
            }
            result = Math.Abs(mainDiagonal - secondaryDiagonal);
            Console.WriteLine(result);

        }


    }
}
