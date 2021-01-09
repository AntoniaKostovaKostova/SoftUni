using System;

namespace Ex08Graduationpt2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double grade = 0d;
            int year = 0;

            while (true)
            {
                double currentGrade = double.Parse(Console.ReadLine());

                year++;
                grade += currentGrade;

                if (currentGrade < 4d)
                {
                    Console.WriteLine($"{name} has been excluded at {year} grade");
                    break;
                }


                if (year == 12)
                {
                    Console.WriteLine($"{name} graduated. Average grade: {grade / 12:F2}");
                    break;
                }
            }
        }
    }
}
