using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Ex02EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex starPattern = new Regex(@"[**]{2}([A-Z][a-z][a-z]+)[**]{2}");
            Regex pointPattern = new Regex(@"[::]{2}([A-Z][a-z][a-z]+)[::]{2}");

            Regex thresholdPattern = new Regex(@"[0-9]");

            MatchCollection starMatch = starPattern.Matches(input);
            MatchCollection pointMatch = pointPattern.Matches(input);


            MatchCollection thresholdMatch = thresholdPattern.Matches(input);

            long coolThreshold = 1;

            foreach (Match number in thresholdMatch)
            {
                coolThreshold *= long.Parse(number.Value.ToString());
            }

            List<string> emoji = new List<string>();

            Dictionary<string, string> pointOrStar = new Dictionary<string, string>();
            foreach (Match star in starMatch)
            {
                Group group = star.Groups[1];
                emoji.Add(group.Value);
                pointOrStar.Add(group.Value, "**");
            }

            foreach (Match point in pointMatch)
            {
                Group group = point.Groups[1];
                emoji.Add(group.Value);
                pointOrStar.Add(group.Value, "::");
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");

            Console.WriteLine($"{emoji.Count} emojis found in the text. The cool ones are:");

            Dictionary<string, long> coolEmoji = new Dictionary<string, long>();

            foreach (var emo in emoji)
            {
                long coolness = 0;
                foreach (char letter in emo)
                {
                    coolness += (int)letter;
                }
                coolEmoji.Add(emo, coolness);
            }

            Dictionary<string, int> sortedEmoji = new Dictionary<string, int>();
            int count = emoji.Count;


                foreach (var emo in coolEmoji.Where(v => v.Value >= coolThreshold))
                {
                    sortedEmoji.Add(emo.Key, input.IndexOf(emo.Key));
                }

            sortedEmoji = sortedEmoji.OrderBy(v => v.Value).ToDictionary(k => k.Key, val => val.Value);

            foreach (var emo in sortedEmoji)
            {
                if (pointOrStar.ContainsKey(emo.Key))
                {
                    Console.WriteLine($"{pointOrStar[emo.Key]}{emo.Key}{pointOrStar[emo.Key]}");
                }
            }
        }


    }
}
