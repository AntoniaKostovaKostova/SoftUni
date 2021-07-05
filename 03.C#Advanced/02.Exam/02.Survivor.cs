using System;
using System.Linq;

namespace _02.Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            //jagged
            char[][] jaggedBeach = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                jaggedBeach[i] = new char[tokens.Length];

                for (int j = 0; j < tokens.Length; j++)
                {
                    var input = tokens[j].ToCharArray().FirstOrDefault();

                    jaggedBeach[i][j] = input;
                }

            }

            string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int collected = 0;
            int opponentCollected = 0;

            while (commands[0] != "Gong")
            {
                if (commands[0] == "Find")
                {
                    int row = int.Parse(commands[1]);
                    int col = int.Parse(commands[2]);

                    if (row >= 0 && row <= rows - 1 && col >= 0 && col <= jaggedBeach[row].Length - 1)
                    {
                        if (jaggedBeach[row][col] == 'T')
                        {
                            jaggedBeach[row][col] = '-';

                            collected++;
                        }
                    }
                }

                else if (commands[0] == "Opponent")
                {
                    int row = int.Parse(commands[1]);
                    int col = int.Parse(commands[2]);
                    string direction = commands[3];

                    if (row >= 0 && row <= rows - 1 && col >= 0 && col <= jaggedBeach[row].Length - 1)
                    {
                        if (jaggedBeach[row][col] == 'T')
                        {
                            jaggedBeach[row][col] = '-';

                            opponentCollected++;
                        }

                        if (direction == "up")
                        {
                            for (int k = 1; k < 4; k++)
                            {
                                if (row - k >= 0 && col <= jaggedBeach[row - k].Length - 1)
                                {
                                    if (jaggedBeach[row - k][col] == 'T')
                                    {
                                        jaggedBeach[row - k][col] = '-';

                                        opponentCollected++;
                                    }
                                }
                                else
                                {
                                    break;
                                }

                            }
                        }
                        else if (direction == "down")
                        {
                            for (int k = 1; k < 4; k++)
                            {
                                if (row + k <= rows - 1 && col <= jaggedBeach[row + k].Length - 1)
                                {
                                    if (jaggedBeach[row + k][col] == 'T')
                                    {
                                        jaggedBeach[row + k][col] = '-';

                                        opponentCollected++;
                                    }
                                }
                                else
                                {
                                    break;
                                }


                            }
                        }
                        else if (direction == "left")
                        {
                            for (int k = 1; k < 4; k++)
                            {
                                if (col - k >= 0)
                                {
                                    if (jaggedBeach[row][col - k] == 'T')
                                    {
                                        jaggedBeach[row][col - k] = '-';

                                        opponentCollected++;
                                    }
                                }
                                else
                                {
                                    break;
                                }


                            }
                        }
                        else if (direction == "right")
                        {
                            for (int k = 1; k < 4; k++)
                            {
                                if (col + k <= jaggedBeach[row].Length - 1)
                                {
                                    if (jaggedBeach[row][col + k] == 'T')
                                    {
                                        jaggedBeach[row][col + k] = '-';

                                        opponentCollected++;
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                }

                commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            }
            foreach (char[] row in jaggedBeach)
            {
                Console.WriteLine(string.Join(" ", row));
            }

            Console.WriteLine($"Collected tokens: {collected}");
            Console.WriteLine($"Opponent's tokens: {opponentCollected}");
        }
    }
}
