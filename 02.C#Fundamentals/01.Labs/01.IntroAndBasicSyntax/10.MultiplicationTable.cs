using System;

namespace Ex10MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());
            for (int times = 1; times <= 10; times++)
            {
                int product = theInteger * times;
                Console.WriteLine("{0} X {1} = {2}", theInteger, times, product);
            }
        }
    }
}
