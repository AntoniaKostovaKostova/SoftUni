using System;
using System.Xml.Schema;

namespace Ex10InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (!(number == 0 || (number >= 100 && number <= 200)))
            Console.WriteLine("invalid");
        }
    }
}
