using System;

namespace Ex02HalfSumElement
{
    class Program
    {

        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int sum = 0;
            int n = 0;
            int max = int.MinValue;

            for (int i = 1; i <= count; i++)
            {
                n = int.Parse(Console.ReadLine());
                sum += n;

                if (n>max)
                {
                    max = n;
                }
            }
            if (max == sum - max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum-max}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum - max - max)}");
            }
        }
    }
}
