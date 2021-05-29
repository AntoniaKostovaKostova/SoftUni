using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = nm[0];
            int cols = nm[1];

            int[,] matrix = new int[rows, cols];

            int maxSum = 0;

            int newMarixRowIndex = 0;
            int newMarixColIndex = 0;

            for (int row = 0; row < rows; row++)
            {
                int[] numbers = Console.ReadLine()
                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                     .Select(int.Parse)
                     .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = numbers[col];

                    int sum = 0;

                    if (row > 1 && col > 1)
                    {
                        sum += matrix[row, col] + matrix[row, col - 1] + matrix[row, col - 2]
                            + matrix[row - 1, col] + matrix[row - 1, col - 1] + matrix[row - 1, col - 2]
                            + matrix[row - 2, col] + matrix[row - 2, col - 1] + matrix[row - 2, col - 2];
                    }

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        newMarixRowIndex = row - 2;
                        newMarixColIndex = col - 2;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");

            for (int row = newMarixRowIndex; row < newMarixRowIndex + 3; row++)
            {
                for (int col = newMarixColIndex; col < newMarixColIndex + 3; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}



