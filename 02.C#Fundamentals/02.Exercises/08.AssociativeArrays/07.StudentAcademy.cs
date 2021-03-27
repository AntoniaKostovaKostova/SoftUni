using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex07StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var academyBook = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();

                if (!academyBook.ContainsKey(name))
                {
                    academyBook.Add(name, new List<double>());
                }

                double grade = double.Parse(Console.ReadLine());

                academyBook[name].Add(grade);

            }

            var academyBookScores = new Dictionary<string, double>();
            foreach (var student in academyBook)
            {
                double average = student.Value.Average();

                academyBookScores.Add(student.Key, average);

            }

            var sortedAcademyBookScores = academyBookScores.Where(v => v.Value >= 4.50).OrderByDescending(g => g.Value);

            foreach (var student in sortedAcademyBookScores)
            {
                Console.WriteLine($"{student.Key} -> {student.Value:F2}");
            }
        }
    }
}
