using System;

namespace Ex01Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double price = 0;
            if (type =="Premiere")
            {
                price = rows * columns * 12;
            }
            else if (type == "Normal")
            {
                price = rows * columns * 7.50;
            }
            else if (type == "Discount")
            {
                price = rows * columns * 5.00;
            }
            Console.WriteLine($"{price:F2} leva");  
        }
    }
}
