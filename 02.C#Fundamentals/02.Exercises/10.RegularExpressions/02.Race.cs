using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;

namespace Ex02Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = Console.ReadLine();

            Regex regexLetters = new Regex(@"[A-Za-z]");
            Regex regexNumbers = new Regex(@"[0-9]");

            Dictionary<string, int> winners = new Dictionary<string, int>();

            foreach (var participant in participants)
            {
                winners.Add(participant, 0);
            }

            while (input != "end of race")
            {
                var matchLetters = regexLetters.Matches(input);
                var matchNumbers = regexNumbers.Matches(input);

                StringBuilder name = new StringBuilder();

                foreach (var letter in matchLetters)
                {
                    name.Append(letter.ToString());
                }

                if (participants.Contains(name.ToString()))
                {
                    var distance = 0;
                    foreach (var number in matchNumbers)
                    {
                        distance += int.Parse(number.ToString());  
                    }

                    winners[name.ToString()] += distance;
                }

                input = Console.ReadLine();
            }

            winners = winners.OrderByDescending(v => v.Value).Take(3).ToDictionary(k => k.Key, v=>v.Value);

            string[] indexes = new []{"1st", "2nd", "3rd" };
            int index = 0;
            foreach (var winner in winners)
            {
                Console.WriteLine($"{indexes[index]} place: {winner.Key}");
                index++;
            }
        }
    }
}
