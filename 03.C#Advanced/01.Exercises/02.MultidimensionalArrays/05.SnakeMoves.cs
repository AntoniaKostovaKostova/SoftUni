using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            string snake = Console.ReadLine();

            char[,] matrix = new char[rows, cols];

            Queue<char> queueSnake = new Queue<char>(rows * cols);

            bool isQueueSnakeFull = false;

            while (!isQueueSnakeFull)
            {
                for (int j = 0; j < snake.Length; j++)
                {
                    queueSnake.Enqueue(snake[j]);
                    if (queueSnake.Count == (rows * cols))
                    {
                        isQueueSnakeFull = true;
                        break;
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        matrix[i, j] = queueSnake.Dequeue();
                    }
                }
                else
                {
                    for (int j = cols-1; j >= 0; j--)
                    {
                        matrix[i, j] = queueSnake.Dequeue();
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
