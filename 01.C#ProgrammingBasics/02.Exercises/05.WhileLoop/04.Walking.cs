using System;

namespace Ex04Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int goal = 10000;
            int counterSteps = 0;

            string input = Console.ReadLine();
            while (true)
            {
                
                if (input!="Going home")
                {
                    int steps = int.Parse(input);
                    counterSteps += steps;
                    if (counterSteps >= goal)
                    {
                        Console.WriteLine($"Goal reached! Good job!");
                        Console.WriteLine($"{counterSteps-goal} steps over the goal!");
                        break;
                    }
                    input = Console.ReadLine();
                }
                else
                {
                    int stepsToHome = int.Parse(Console.ReadLine());
                    counterSteps += stepsToHome;
                    if (counterSteps < goal)
                    {
                        Console.WriteLine($"{goal-counterSteps} more steps to reach goal.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Goal reached! Good job!");
                        Console.WriteLine($"{counterSteps - goal} steps over the goal!");
                        break;
                    }
                }
                
            }
        }
    }
}
