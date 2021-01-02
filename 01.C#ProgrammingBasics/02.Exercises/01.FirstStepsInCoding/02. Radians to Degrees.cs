using System;

namespace RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());
            double deg = rad * (180 / Math.PI);
            double result = Math.Round(deg);
            Console.WriteLine(result);
        }
    }
}
