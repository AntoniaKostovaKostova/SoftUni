using System;

namespace Ex08BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte times = byte.Parse(Console.ReadLine());
            double volume = 0;
            double biggestKeg = 0;
            string answer = "";
            for (int i = 0; i < times; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                volume = Math.Round(Math.PI, 2) * (Math.Pow(radius, 2)) * height;
                if (volume > biggestKeg)
                {
                    biggestKeg = volume;
                    answer = model;
                }
            }
            Console.WriteLine(answer);
        }
    }
}
