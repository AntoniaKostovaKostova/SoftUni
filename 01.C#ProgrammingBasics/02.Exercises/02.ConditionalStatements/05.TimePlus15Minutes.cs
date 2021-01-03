using System;

namespace Ex05TimeAnd15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if (minutes <= 44)
            {
                minutes += 15;
            }
            else
            {
                hour++;
                minutes += 15;
                minutes %= 60;   
            }

            if (hour == 24)
            {
                hour = 0;
            }

            if (minutes < 10)
            {
                Console.WriteLine($"{hour}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hour}:{minutes}");
            }
        }
    }
}
