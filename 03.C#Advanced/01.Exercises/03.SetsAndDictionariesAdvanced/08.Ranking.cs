using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestPasswords = new Dictionary<string, string>();

            string input = Console.ReadLine();

            while (input != "end of contests")
            {
                string[] line = input.Split(":", StringSplitOptions.RemoveEmptyEntries);

                string contest = line[0];
                string password = line[1];

                if (!contestPasswords.ContainsKey(contest))
                {
                    contestPasswords.Add(contest, password);
                }

                input = Console.ReadLine();
            }

            string secondInput = Console.ReadLine();

            SortedDictionary<string, Dictionary<string, int>> submissions = new SortedDictionary<string, Dictionary<string, int>>();

            while (secondInput != "end of submissions")
            {
                string[] secondLine = secondInput.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string contest = secondLine[0];
                string password = secondLine[1];
                string username = secondLine[2];
                int points = int.Parse(secondLine[3]);

                if (contestPasswords.ContainsKey(contest))
                {
                    if (contestPasswords[contest] == password)
                    {
                        if (!submissions.ContainsKey(username))
                        {
                            submissions[username] = new Dictionary<string, int> { { contest, 0 } };
                        }

                        if (!submissions[username].ContainsKey(contest))
                        {
                            submissions[username].Add(contest, 0);
                        }

                        if (submissions[username][contest] < points)
                        {
                            submissions[username][contest] = points;
                        }

                    }
                }

                secondInput = Console.ReadLine();
            }

            int maxPoints = 0;

            Dictionary<string, int> usernameTotalPoints = new Dictionary<string, int>();

            foreach (var kvp in submissions)
            {
                foreach (var student in kvp.Value)
                {
                    if (!usernameTotalPoints.ContainsKey(kvp.Key))
                    {
                        usernameTotalPoints.Add(kvp.Key, student.Value);
                    }
                    else
                    {
                        usernameTotalPoints[kvp.Key] += student.Value;
                    }
                    //foreach (var kvp in submissions)
                    //{
                    //    usernameTotalPoints[kvp.Key] = kvp.Value.Values.Sum();
                    //}
                }
            }

            usernameTotalPoints = usernameTotalPoints.OrderByDescending(v => v.Value).ToDictionary(x => x.Key, y => y.Value);

            Console.WriteLine($"Best candidate is {usernameTotalPoints.FirstOrDefault().Key} with total {usernameTotalPoints.FirstOrDefault().Value} points.");

            //string bestCandidate = studentsDictionary
            //    .Keys
            //    .Max();

            //int bestPoints = studentsDictionary
            //    .Values
            //    .Max();

            //Console.WriteLine($"Best candidate is {bestCandidate} with total {bestPoints} points.");

            Console.WriteLine($"Ranking:");

            foreach (var user in submissions.OrderBy(x=>x.Key))
            {
                Console.WriteLine(user.Key);

                //Console.WriteLine(string.Join(Environment.NewLine, kvp.Value
                //    .OrderByDescending(x => x.Value)
                //    .Select(a => $"#  {a.Key} -> {a.Value}")
                //    ));

                foreach (var contest in user.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }

        }

    }
}
