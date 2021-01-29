using System;

namespace Ex05PrintPartOfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            byte first = byte.Parse(Console.ReadLine());
            byte second = byte.Parse(Console.ReadLine());

            for (char i = (char)first; i <= second; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
