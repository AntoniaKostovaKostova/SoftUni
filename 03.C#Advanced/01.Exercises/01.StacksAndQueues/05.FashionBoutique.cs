using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothesInTheBox = ReadFromConsole();

            int capciyOfTheNewRack = int.Parse(Console.ReadLine());

            int numberOfRacks = 1;

            Stack<int> stack = new Stack<int>();

            int sumClothes = 0;

            foreach (var clothes in clothesInTheBox)
            {
                stack.Push(clothes);
            }

            int capciyOfTheRack = capciyOfTheNewRack;

            while (stack.Count > 0)
            {
                
                if (capciyOfTheRack > stack.Peek())
                {
                    capciyOfTheRack -= stack.Peek();
                    sumClothes += stack.Pop();

                }
                else if (capciyOfTheRack == stack.Peek())
                {
                    stack.Pop();
                    if (stack.Count > 0)
                    {
                        numberOfRacks++;
                        sumClothes = 0;
                        capciyOfTheRack = capciyOfTheNewRack;
                    }                  
                }
                else
                {
                    numberOfRacks++;
                    sumClothes = 0;
                    capciyOfTheRack = capciyOfTheNewRack - stack.Peek();
                    sumClothes += stack.Pop();
                }
            }
            Console.WriteLine(numberOfRacks);
        }

        private static int[] ReadFromConsole()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
