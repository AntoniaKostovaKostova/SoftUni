using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex06Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" : ", StringSplitOptions.RemoveEmptyEntries);

            var courses = new Dictionary<string, List<string>>();

            while (input[0].ToString() != "end")
            {
                string course = input[0];
                string student = input[1];

                if (!courses.ContainsKey(course))
                {
                    courses.Add(course, new List<string> { student });
                }
                else
                {
                    var myList = courses[course];
                    myList.Add(student);
                }
                input = Console.ReadLine()
                .Split(" : ", StringSplitOptions.RemoveEmptyEntries);
            }

            var sortedCourses = courses.OrderByDescending(pair => pair.Value.Count)
                .ToDictionary(pair => pair.Key, pair => pair.Value);


            foreach (var course in sortedCourses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                sortedCourses[course.Key].Sort();

                foreach (var student in sortedCourses[course.Key])
                {
                    Console.WriteLine($"-- {student}");
                }
            }

        }
    }
}
