using System;

namespace Ex03SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicialNumber = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            int sum = number;

            while (sum < inicialNumber)
            {
                number = int.Parse(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine(sum);

        }
    }
}
