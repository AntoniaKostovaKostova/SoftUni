using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex01Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            List<string> input = null;

            while (true)
            {
                input = Console.ReadLine()
                    .Split()
                    .ToList();
                if (input.Contains("end"))
                {
                    break;
                }
                else if (input.Count > 1)
                {
                    int passangers = int.Parse(input[1]);
                    wagons.Add(passangers);
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if ((wagons[i] + int.Parse(input[0])) <= maxCapacity)
                        {
                            wagons[i] = wagons[i] + int.Parse(input[0]);
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }


            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
