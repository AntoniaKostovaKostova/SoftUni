using System;

namespace VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int sheets = int.Parse(Console.ReadLine());
            double readSheets = double.Parse(Console.ReadLine());
            int daysToRead = int.Parse(Console.ReadLine());

            double hoursToReadPerDay = (sheets / readSheets)/daysToRead;
            Console.WriteLine(hoursToReadPerDay);
        }
    }
}
