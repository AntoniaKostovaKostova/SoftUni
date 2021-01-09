using System;
using System.Runtime.CompilerServices;

namespace Ex09Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int sizeRoom = width * lenght * height;
            int sizeBox = 0;

            string boxCommand = Console.ReadLine();
            while (boxCommand != "Done")
            {
                int boxNumber = int.Parse(boxCommand);
                sizeBox += boxNumber;

                if (sizeRoom < sizeBox)
                {
                    Console.WriteLine($"No more free space! You need {sizeBox-sizeRoom} Cubic meters more.");
                    break;
                }
                boxCommand = Console.ReadLine();
            }
            if (boxCommand == "Done")
            {
                Console.WriteLine($"{sizeRoom-sizeBox} Cubic meters left.");
            }
           
        }
    }
}
