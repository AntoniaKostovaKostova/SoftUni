using System;

namespace Ex04SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfLines = byte.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < numberOfLines; i++)
            {
                char line = char.Parse(Console.ReadLine());
                sum += line;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
