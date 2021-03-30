using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Ex01Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double moneySpend = 0;

            List<string> items = new List<string>();

            Regex regex = new Regex(@"^>>([A-Z]+[a-z]*)<<(\d+\.?\d*)!(\d+)");

            while (input != "Purchase")
            {
                Match match = regex.Match(input);

                var quantity = match.Groups[2];
                var price = match.Groups[3];

                if (match.Length > 0)
                {
                    moneySpend += Double.Parse(quantity.Value) * Double.Parse(price.Value);

                    items.Add(match.Groups[1].Value);
                }

                input = Console.ReadLine();
            }

            items = items.Where(i => i.Length > 0).ToList();

            Console.WriteLine("Bought furniture:");
            if (items.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, items));
            }
            Console.WriteLine($"Total money spend: {moneySpend:F2}");
        }
    }
}
