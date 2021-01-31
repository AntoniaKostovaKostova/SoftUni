using System;

namespace Ex09CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLine = char.Parse(Console.ReadLine());
            char secondLine = char.Parse(Console.ReadLine());
            char thirdLine = char.Parse(Console.ReadLine());
            
            Console.WriteLine($"{firstLine}{secondLine}{thirdLine}");
        }
    }
}
