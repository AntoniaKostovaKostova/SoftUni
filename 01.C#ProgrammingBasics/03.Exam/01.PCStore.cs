using System;

namespace Ex01PCStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double processorPrice = double.Parse(Console.ReadLine());
            double videoPrice = double.Parse(Console.ReadLine());
            double ramPrice = double.Parse(Console.ReadLine());
            int ramCount = int.Parse(Console.ReadLine());
            double procentDiscount = double.Parse(Console.ReadLine());


            processorPrice = processorPrice * 1.57;
            videoPrice = videoPrice * 1.57;
            ramPrice = ramPrice * 1.57;
            double allRamPrice = ramPrice * ramCount;
            processorPrice = processorPrice - processorPrice * procentDiscount;
            videoPrice = videoPrice - videoPrice * procentDiscount;
            double sum = processorPrice + videoPrice + allRamPrice;

            Console.WriteLine($"Money needed - {sum:f2} leva.");
        }
    }
}
