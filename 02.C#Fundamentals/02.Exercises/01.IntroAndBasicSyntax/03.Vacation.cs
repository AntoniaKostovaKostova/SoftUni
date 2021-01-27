using System;

namespace Ex03Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            double discount = 0;

            if (type == "Students")
            {
                if (number >= 30)
                {
                    discount = 0.15;
                }
                if (day == "Friday")
                {
                    price = 8.45;
                }
                else if (day == "Saturday")
                {
                    price = 9.80;
                }
                else if (day == "Sunday")
                {
                    price = 10.46;
                }
            }
            else if (type == "Business")
            {
                if (number >= 100)
                {
                    number = number - 10;
                }
                if (day == "Friday")
                {
                    price = 10.90;
                }
                else if (day == "Saturday")
                {
                    price = 15.60;
                }
                else if (day == "Sunday")
                {
                    price = 16;
                }
            }
            else if (type == "Regular")
            {
                if (number >= 10 && number <= 20)
                {
                    discount = 0.05;
                }
                if (day == "Friday")
                {
                    price = 15;
                }
                else if (day == "Saturday")
                {
                    price = 20;
                }
                else if (day == "Sunday")
                {
                    price = 22.50;
                }
            }
            Console.WriteLine($"Total price: {(price-(price*discount))*number:F2}");
        }
    }
}
