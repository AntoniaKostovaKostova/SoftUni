using System;

namespace Ex08Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double familyIncome = double.Parse(Console.ReadLine());
            double result = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());
            double scholarship;

            bool canGetSocialScholarship = (familyIncome < minSalary) && (result > 4.5);
            bool canGetExcellent = result >= 5.5;

            if (canGetSocialScholarship && canGetExcellent)
            {
                bool isExcellentHigher = 0.35 * minSalary < result * 0.25;

                if (isExcellentHigher)
                {
                    scholarship = result * 0.25;
                    Console.WriteLine($"You get a scholarship for excellent results {(int)(scholarship)} BGN");
                }
                else
                {
                    scholarship = 0.35 * minSalary;
                    Console.WriteLine($"You get a Social scholarship {(int)(scholarship)} BGN");
                }

            }
            else if (canGetSocialScholarship)
            {
                scholarship = 0.35 * minSalary;
                Console.WriteLine($"You get a Social scholarship {(int)(scholarship)} BGN");

            }
            else if (canGetExcellent)
            {
                scholarship = result * 0.25;
                Console.WriteLine($"You get a scholarship for excellent results {(int)(scholarship)} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
