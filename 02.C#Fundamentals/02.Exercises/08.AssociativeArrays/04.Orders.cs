using System;
using System.Collections.Generic;

namespace Ex04Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var products = new Dictionary<string, List<double>>();

            string name = string.Empty;
            double price = 0;
            double quantity = 0;

            while (input[0].ToString() != "buy")
            {
                name = input[0];
                price = double.Parse(input[1]);
                quantity = double.Parse(input[2]);

                if (!products.ContainsKey(name))
                {
                    products.Add(name, new List<double> { price, quantity, price * quantity });
                }
                else
                {
                    //replace price
                    //add quantity
                    var currentProductPriceAndQuantity = products[name];

                    currentProductPriceAndQuantity[0] = price;
                    currentProductPriceAndQuantity[1] += quantity;

                    currentProductPriceAndQuantity[2] = currentProductPriceAndQuantity[0] * currentProductPriceAndQuantity[1];
                }

                input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} -> {product.Value[2]:F2}");
            }

        }
    }
}
