using System;

namespace Ex09PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceSabre = double.Parse(Console.ReadLine());
            double priceRobe = double.Parse(Console.ReadLine());
            double priceBelt = double.Parse(Console.ReadLine());
            double price = 0;
            int freeBelt = students / 6;
            price = ((Math.Ceiling(students * 1.1)) * priceSabre) + (students * priceRobe) + ((students - freeBelt) * priceBelt);
            if (price <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {price:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {price - money:F2}lv more.");
            }
        }
    }
}
