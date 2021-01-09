using System;

namespace Ex06Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int cake = width * height;
            int countPieces = 0;
            string input = Console.ReadLine();
            while (true)
            {
                if (input != "STOP")
                {
                    int pieces = int.Parse(input);
                    countPieces += pieces;

                    if (cake < countPieces)
                    {
                        Console.WriteLine($"No more cake left! You need {countPieces - cake} pieces more.");
                        break;
                    }
                }
                else
                {
                    if (cake >= countPieces)
                    {
                        Console.WriteLine($"{cake - countPieces} pieces are left.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"No more cake left! You need {cake- countPieces} pieces more.");
                        break;
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
