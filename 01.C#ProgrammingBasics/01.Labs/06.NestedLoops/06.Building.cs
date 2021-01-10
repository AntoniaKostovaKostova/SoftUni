using System;

namespace Ex06Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int roomsPerFloor = int.Parse(Console.ReadLine());

            for (int i = floors; i >= 1; i--)
            {
                char letter = 'c';
                if (i == floors)
                {
                    letter = 'L';
                }
                else if (i % 2 == 0)
                {
                    letter = 'O';
                }
                else if (i % 2 != 0)
                {
                    letter = 'A';
                }

                for (int j = 0; j < roomsPerFloor; j++)
                {
                    Console.Write($"{letter}{i}{j} ");
                }
                Console.WriteLine();
            }
        }
    }
}
