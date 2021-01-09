using System;

namespace Ex02ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            int counter = 0;
            double sumGrades = 0;
            int badGradesCounter = 0;
            string bookName = "";
            //string command = Console.ReadLine();
            while (true)
            {
                string name = Console.ReadLine();
                if (name !="Enough")
                {
                    bookName = name;
                }
                else if (name == "Enough")
                {
                    Console.WriteLine($"Average score: {sumGrades/counter:F2}");
                    Console.WriteLine($"Number of problems: {counter}");
                    Console.WriteLine($"Last problem: {bookName}");
                    break;
                }

                int grade = int.Parse(Console.ReadLine());
                sumGrades += grade;
                if (grade<=4.00)
                {
                    badGradesCounter++;
                }
                if (badGrades==badGradesCounter)
                {
                    Console.WriteLine($"You need a break, {badGradesCounter} poor grades.");
                    break;
                }
                counter++;
            }
        }
    }
}
