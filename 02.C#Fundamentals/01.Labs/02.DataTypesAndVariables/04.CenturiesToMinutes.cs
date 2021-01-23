using System;

namespace Ex04CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            int years = 100 * centuries;
            int days = (int)Math.Truncate(365.2422 * years);
            long hours = 24 * days;
            long minutes = 60 * hours;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
