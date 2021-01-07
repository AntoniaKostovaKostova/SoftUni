using System;

namespace Ex09LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 1; i <= n; i++)
            {
                int left = int.Parse(Console.ReadLine());
                leftSum += left;
            }
            for (int t = n + 1; t <= 2*n; t++)
            {
                int right = int.Parse(Console.ReadLine());
                rightSum += right;
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }
        }
    }
}
