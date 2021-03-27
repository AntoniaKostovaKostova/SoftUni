using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex10SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var contest = new Dictionary<string, int>();
            var submissions = new Dictionary<string, int>();

            while (input != "exam finished")
            {
                string[] information = input.Split("-");
                if (information.Length == 3)
                {
                    string name = information[0];
                    string language = information[1];
                    int score = int.Parse(information[2]);

                    if (!contest.ContainsKey(name))
                    {
                        contest.Add(name, score);
                    }

                    else
                    {
                        if (contest[name] <= score)
                        {
                            contest[name] = score;
                        }
                        
                    }

                    if (!submissions.ContainsKey(language))
                    {
                        submissions.Add(language, 1);
                    }

                    else
                    {
                        submissions[language] += 1;
                    }

                }
                else if (information.Length == 2)
                {
                    string name = information[0];

                    if (contest.ContainsKey(name))
                    {
                        contest.Remove(name);
                    }
                }

                input = Console.ReadLine();

            }
            var orderedContest = contest.OrderByDescending(points => points.Value).ThenBy(name => name.Key);
            var orderedSubmissions = submissions.OrderByDescending(sub => sub.Value).ThenBy(language => language.Key);

            Console.WriteLine("Results:");
            foreach (var participant in orderedContest)
            {
                Console.WriteLine($"{participant.Key} | {participant.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (var participant in orderedSubmissions)
            {
                Console.WriteLine($"{participant.Key} - {participant.Value}");
            }
        }
    }
}
