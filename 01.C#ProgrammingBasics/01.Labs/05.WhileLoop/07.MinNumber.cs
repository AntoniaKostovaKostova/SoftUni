using System;

namespace Ex07MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int minNumber = int.MaxValue;

            while (command!="Stop")
            {
                int number = int.Parse(command);
                if (minNumber > number)
                {
                    minNumber = number;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(minNumber);
        }
    }
}
