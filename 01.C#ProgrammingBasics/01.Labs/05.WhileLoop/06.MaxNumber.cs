using System;

namespace Ex06MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int maxNumber = int.MinValue;

            while (command != "Stop")
            {
                int number = int.Parse(command);
                command = Console.ReadLine();

                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
