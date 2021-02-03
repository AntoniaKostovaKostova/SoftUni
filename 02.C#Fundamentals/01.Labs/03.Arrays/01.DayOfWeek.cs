using System;

namespace Ex01DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] daysOfWeek = new string[7] {"Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"};
            {
                try
                {
                    Console.WriteLine(daysOfWeek[number - 1]);
                }
                catch
                {
                    Console.WriteLine("Invalid day!");
                }
            }
        }
    }
}
