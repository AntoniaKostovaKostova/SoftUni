using System;
using System.Linq;
namespace Ex06EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool isEqual = false;

            for (int i = 0; i < array.Length; i++)
            {
                int currentNumber = array[i];
                int sumLeft = 0;
                int sumRight = 0;

                if (i != array.Length - 1)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        sumRight += array[j];
                    }
                }
                else
                {
                    sumRight += 0;
                }
                if (i != 0)
                {
                    for (int k = i - 1; k >= 0; k--)
                    {
                        sumLeft += array[k];
                    }
                }
                else
                {
                    sumLeft += 0;
                }

                if (sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    isEqual = true;
                }           
            }
            if (isEqual == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
