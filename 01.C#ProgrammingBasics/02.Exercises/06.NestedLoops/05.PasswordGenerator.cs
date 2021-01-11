using System;

namespace Ex05PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            
                for (int first = 1; first <= n; first++)
                {
                    for (int sec = 1; sec <= n; sec++)
                    {
                        for (char third = 'a'; third <= 'a' + l - 1; third++)
                        {
                            for (char fourth = 'a'; fourth <= 'a' + l - 1; fourth++)
                            {
                                for (int fifth = 1; fifth <= n; fifth++)
                                {
                                    if (fifth > first && fifth > sec)
                                    {
                                        Console.Write($"{first}{sec}{third}{fourth}{fifth} ");
                                    }
                                }
                            }
                        }
                    }
                }
            
        }
    }
}
