using System;

namespace Ex10PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int pokes = 0;
            int originalN = n;

            while (n >= m)
            {
                n = n - m;
                pokes++;
                if (originalN / 2 == n && y != 0)
                {
                    n = n / y;
                }

            }
            Console.WriteLine(n);
            Console.WriteLine(pokes);
        }
    }
}
