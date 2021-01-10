using System;

namespace Ex01Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int firstNum = 1; firstNum <= 10; firstNum++)
            {
                for (int secondNum = 1; secondNum <= 10; secondNum++)
                {
                    Console.WriteLine($"{firstNum} * {secondNum} = {firstNum*secondNum}");
                }
            }
        }
    }
}
