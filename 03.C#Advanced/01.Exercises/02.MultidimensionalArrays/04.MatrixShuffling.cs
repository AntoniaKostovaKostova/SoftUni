using System;
using System.Linq;

namespace _4.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            string[,] matrix = new string[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = input[j];
                }

            }

            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int row1 = 0;
            int row2 = 0;
            int col1 = 0;
            int col2 = 0;
            bool isCorrectLenght = false;

            while (command[0] != "END")
            {
                if (command.Length == 5)
                {
                    row1 = int.Parse(command[1]);
                    row2 = int.Parse(command[3]);
                    col1 = int.Parse(command[2]);
                    col2 = int.Parse(command[4]);

                    isCorrectLenght = true;
                }

                if (command[0] == "swap" && isCorrectLenght && row1 >= 0 && row2 <= rows && col1 >= 0 && col2 <= cols)
                {
                    var temp = matrix[row1, col1];
                    matrix[row1, col1] = matrix[row2,col2];
                    matrix[row2, col2] = temp;

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            Console.Write($"{matrix[i,j]} ");
                        }
                        Console.WriteLine();
                    }                
                }

                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
