using System;

namespace Ex01ExcellentResult
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            bool isHigher = number >= 5.50;
            if (isHigher)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
