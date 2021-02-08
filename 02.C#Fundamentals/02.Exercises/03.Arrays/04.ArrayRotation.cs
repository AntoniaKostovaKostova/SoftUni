using System;

namespace Ex04ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine()
                .Split();

            int rotations = int.Parse(Console.ReadLine());
       
            for (int i = 0; i < rotations; i++)
            {
                string firstElement = array[0];

                for (int j = 1; j < array.Length; j++)
                {
                    int prevIndex = j - 1;
                    array[prevIndex] = array[j];

                }
                array[array.Length - 1] = firstElement;
            }
            foreach (var element in array)
            {
                Console.Write($"{element} ");
            }
        }
        
    }
}
