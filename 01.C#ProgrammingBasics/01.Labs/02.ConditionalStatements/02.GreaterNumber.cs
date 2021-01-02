using System;

namespace Ex02GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a >= b)
            {
                Console.WriteLine(a);
            }
            else if (b >= a)
            {
                Console.WriteLine(b);
            }
        }
    }
}
