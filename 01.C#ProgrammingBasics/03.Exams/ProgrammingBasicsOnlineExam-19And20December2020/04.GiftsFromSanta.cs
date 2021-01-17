using System;

namespace Ex04GiftsFromSanta
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            for (int i = m; i >= n; i--)
            {
                if (i % 2 == 0)
                {
                    if (i % 3 == 0)
                    {
                        if (i == s)
                        {
                            break;
                        }
                        else
                        {
                            Console.Write(i + " ");
                        }
                    }
                }
            }
        }
    }
}
