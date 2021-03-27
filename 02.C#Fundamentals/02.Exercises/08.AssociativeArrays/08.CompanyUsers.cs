using System;
using System.Collections.Generic;

namespace Ex08CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

            var book = new SortedDictionary<string, List<string>> ();

            while (input[0].ToString() != "End")
            {
                string company = input[0];
                string id = input[1];

                if (!book.ContainsKey(company))
                {
                    book.Add(company, new List<string> { id });
                }
                else
                {
                    var myList = book[company];
                    if (!myList.Contains(id))
                    {
                        myList.Add(id);
                    }
                }


                input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var kvp in book)
            {

                Console.WriteLine($"{kvp.Key}");

                foreach (var id in kvp.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }


        }
    }
}
