using System;

namespace UsdToBgn
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd;
            double bgn = double.Parse(Console.ReadLine());
            usd = 1.79549 * bgn;
            Console.WriteLine(usd);
        }
    }
}
