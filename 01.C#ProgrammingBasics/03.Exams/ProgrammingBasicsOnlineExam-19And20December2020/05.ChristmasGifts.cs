using System;

namespace Ex05ChristmasGifts
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int counterChild = 0;
            int counterOld = 0;

            while (input != "Christmas")
            {
                int age = int.Parse(input);

                if(age<=16)
                {
                    counterChild++;
                }
                else
                {
                    counterOld++;
                }
                input = Console.ReadLine();
            }
            int toysPrice = counterChild * 5;
            int topsPrice = counterOld * 15;
            Console.WriteLine($"Number of adults: {counterOld}");
            Console.WriteLine($"Number of kids: {counterChild}");
            Console.WriteLine($"Money for toys: {toysPrice}");
            Console.WriteLine($"Money for sweaters: {topsPrice}");
        }
    }
}
