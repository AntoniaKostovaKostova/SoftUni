using System;

namespace Ex07SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNumbers = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= countNumbers; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                sum += numbers;               
            }
            Console.WriteLine(sum);
        }
    }
}
