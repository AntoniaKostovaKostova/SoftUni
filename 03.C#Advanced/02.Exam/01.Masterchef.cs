using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Masterchef
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nIngredients = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[] nFreshness = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> ingredientsQueue = new Queue<int>(nIngredients);

            Stack<int> freshnessStack = new Stack<int>(nFreshness);

            SortedDictionary<string, int> resultDictionary = new SortedDictionary<string, int>();

            while (ingredientsQueue.Count != 0 && freshnessStack.Count != 0)
            {
                var currIngredient = ingredientsQueue.Peek();

                if (currIngredient == 0)
                {
                    ingredientsQueue.Dequeue();
                    continue;
                }

                var sum = ingredientsQueue.Dequeue() * freshnessStack.Pop();

                if (sum == 150)
                {
                    if (!resultDictionary.ContainsKey("Dipping sauce"))
                    {
                        resultDictionary.Add("Dipping sauce", 0);
                    }
                    resultDictionary["Dipping sauce"] += 1;
                }
                else if (sum == 250)
                {
                    if (!resultDictionary.ContainsKey("Green salad"))
                    {
                        resultDictionary.Add("Green salad", 0);
                    }
                    resultDictionary["Green salad"] += 1;
                }
                else if (sum == 300)
                {
                    if (!resultDictionary.ContainsKey("Chocolate cake"))
                    {
                        resultDictionary.Add("Chocolate cake", 0);
                    }
                    resultDictionary["Chocolate cake"] += 1;
                }
                else if (sum == 400)
                {
                    if (!resultDictionary.ContainsKey("Lobster"))
                    {
                        resultDictionary.Add("Lobster", 0);
                    }
                    resultDictionary["Lobster"] += 1;
                }
                else
                {
                    currIngredient += 5;
                    ingredientsQueue.Enqueue(currIngredient);
                }
            }

            //Dish Freshness Level needed
            //Dipping sauce   150
            //Green salad 250
            //Chocolate cake  300
            //Lobster 400

            if (resultDictionary.Count >= 4)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
            }

            if (ingredientsQueue.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {ingredientsQueue.Sum()}");
            }

            foreach (var kvp in resultDictionary)
            {
                Console.WriteLine($" # {kvp.Key} --> {kvp.Value}");
            }

            //Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            //Console.WriteLine("You were voted off. Better luck next year.");
            //Console.WriteLine($" Ingredients left: {ingridientsSum}");
            //Console.WriteLine($" # {dish name} --> {amount}");

        }
    }
}
