using System;

namespace Ex10MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            int times = multiplier;
            int product = theInteger * times;

            for (; times <= 10; times++)
            {
                product = theInteger * times;
                Console.WriteLine("{0} X {1} = {2}", theInteger, times, product);
            }
            if (multiplier>10)
            {
                Console.WriteLine("{0} X {1} = {2}", theInteger, times, product);
            }
        }
    }
}
