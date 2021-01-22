using System;

namespace Ex04BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if (minutes + 30 >= 60)
            {
                hours++;
                minutes = minutes + 30 - 60;
            }
            else
            {
                minutes = minutes + 30;
            }
            if (hours == 24 || hours == 0)
            {
                hours = 0;
            }
            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
