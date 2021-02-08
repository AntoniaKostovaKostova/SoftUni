using System;
using System.Linq;

namespace Ex01Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOfPeople = 0;
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                int people = int.Parse(Console.ReadLine());
                sumOfPeople += people;
                array[i] = people;
            }
            for (int j = 0; j <= array.Length-1; j++)
            {
                Console.Write(array[j] + " ");                
            }
            Console.WriteLine();
            Console.WriteLine(sumOfPeople);
        }
    }
}
