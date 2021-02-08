using System;
using System.Linq;

namespace Ex02CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine()
                .Split();

            string[] secondArray = Console.ReadLine()
                .Split();

            foreach (var second in secondArray)
            {
                foreach (var first in firstArray)
                {
                    if (second == first)
                    {
                        Console.Write(second + " ");
                    }
                }
            }            
                       
        }
    }
}
