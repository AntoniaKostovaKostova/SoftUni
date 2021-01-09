using System;

namespace Ex01OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            int times = 0;
            while (true)
            {
                string bookNameInside = Console.ReadLine();

                if (bookName == bookNameInside)
                {
                    Console.WriteLine($"You checked {times} books and found it.");
                    break;
                }
                
                if (bookNameInside == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {times} books.");
                    break;
                }
                times++;
            }
            

        }
    }
}
