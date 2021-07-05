using System;
using System.Linq;

namespace _6.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] jagged = new double[rows][];

            for (int i = 0; i < rows; i++)
            {
                int[] row = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                jagged[i] = new double[row.Length];

                for (int j = 0; j < row.Length; j++)
                {
                    jagged[i][j] = row[j];
                }
            }

            for (int i = 0; i < rows - 1; i++)
            {
                if (jagged[i].Length == jagged[i + 1].Length)
                {
                    for (int j = 0; j < jagged[i].Length; j++)
                    {
                        jagged[i][j] *= 2;
                    }

                    for (int j = 0; j < jagged[i + 1].Length; j++)
                    {
                        jagged[i + 1][j] *= 2;
                    }

                }

                else
                {
                    for (int j = 0; j < jagged[i].Length; j++)
                    {
                        if (jagged[i][j] != 0)
                        {
                            jagged[i][j] /= 2;
                        }
                    }

                    for (int j = 0; j < jagged[i + 1].Length; j++)
                    {
                        if (jagged[i+1][j] != 0)
                        {
                            jagged[i + 1][j] /= 2;
                        }

                    }

                }
            }

            string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (commands[0] != "End")
            {
                int row = int.Parse(commands[1]);
                int col = int.Parse(commands[2]);
                int value = int.Parse(commands[3]);

                if (row >= 0 && col <= jagged[row].Length)
                {
                    if (commands[0] == "Add")
                    {
                        jagged[row][col] += value;
                    }

                    else if (commands[0] == "Subtract")
                    {
                        jagged[row][col] -= value;
                    }
                }
                commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var kvp in jagged)
            {
                Console.WriteLine(string.Join(" ", kvp));
            }
        }
    }
}

