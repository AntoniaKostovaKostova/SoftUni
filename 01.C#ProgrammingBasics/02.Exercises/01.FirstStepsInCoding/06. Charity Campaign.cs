using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int shefs = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int goffrettes = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double priceCakes = cakes * 45;
            double priceGoffrettes = goffrettes * 5.80;
            double pricePancakes = pancakes * 3.20;


            double money = days * shefs * (priceCakes + priceGoffrettes + pricePancakes);
            double sum = money - (money / 8);

            Console.WriteLine(sum);
        }
    }
}
