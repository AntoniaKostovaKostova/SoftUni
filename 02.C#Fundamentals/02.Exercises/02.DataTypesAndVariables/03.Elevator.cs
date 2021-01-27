using System;

namespace Ex03Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = 0;

            while (people > 0)
            {
                if (people - capacity >= 0)
                {
                    courses++;
                    people = people - capacity;
                }
                else
                {
                    people = 0;
                    courses++;
                }
            }
            Console.WriteLine(courses);
        }
    }
}
