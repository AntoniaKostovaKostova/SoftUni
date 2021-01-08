using System;

namespace Ex06Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int countTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            for (int i = 1; i <= countTabs; i++)
            {
                string tab = Console.ReadLine();
                switch (tab)
                {
                    case "Facebook":
                        salary -= 150;
                        break;
                    case "Instagram":
                        salary -= 100;
                        break;
                    case "Reddit":
                        salary -= 50;
                        break;
                }
                if (salary <= 0)
                {
                    i = countTabs;
                    Console.WriteLine("You have lost your salary.");
                }
            }
            if (salary > 0)
            {
                Console.WriteLine($"{salary}");
            }

        }
    }
}
