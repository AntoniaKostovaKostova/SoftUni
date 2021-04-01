using System;
using System.Text.RegularExpressions;

namespace Ex03SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"%([A-Z][a-z]+)%[^\|\$\%\.]*<(\w+)>[^\|\$\%\.]*\|*([0-9]+)\|[^\|\$\%\.]*?([0-9]+\.?[0-9]*)[^\|\$\%\.]*\$");

            double income = 0;

            while (input != "end of shift")
            {
                Match match = regex.Match(input);

                string customer = string.Empty;
                string product = string.Empty;
                double count = 0;
                double price = 0;

                if (match.Groups[1].Value.Length > 0 && match.Groups[2].Value.Length > 0 && match.Groups[3].Value.Length > 0 && match.Groups[4].Value.Length > 0)
                {
                    customer = match.Groups[1].Value;

                    product = match.Groups[2].Value;

                    count = double.Parse(match.Groups[3].Value.ToString());

                    price = double.Parse(match.Groups[4].Value.ToString());

                    income += count * 1.0 * price;

                    Console.WriteLine($"{customer}: {product} - {count * price * 1.0:F2}");
               
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {income:F2}");
        }
    }
}
