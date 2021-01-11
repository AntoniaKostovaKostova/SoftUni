using System;

namespace Ex04TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int judges = int.Parse(Console.ReadLine());
            string presentationName = Console.ReadLine();
            double averageMarkFromAll = 0;
            int countPresentations = 0;
            while (presentationName != "Finish")
            {
                countPresentations++;
                double sumMark = 0;
                for (int i = 1; i <= judges; i++)
                {
                    double mark = double.Parse(Console.ReadLine());
                    sumMark += mark;
                }

                double averageMark = sumMark / judges;
                averageMarkFromAll += averageMark;
                Console.WriteLine($"{presentationName} - {averageMark:f2}.");
                presentationName = Console.ReadLine();
            }
            if (presentationName == "Finish")
            {
                Console.WriteLine($"Student's final assessment is {averageMarkFromAll/countPresentations:f2}.");
            }
          
        }
    }
}
