using System;
using System.Collections.Generic;

namespace Ex01ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] names = input.Split(", ");
            
            List<string> validNames = new List<string>();

            for (int i = 0; i < names.Length; i++)
            {
                bool isValid = true;

                if (!(names[i].Length >= 3 && names[i].Length <= 16))
                {
                    isValid = false;
                }
                for (int k = 0; k < names[i].Length; k++)
                {                    
                    if (!(names[i][k] >= 48 && names[i][k] <= 57) && !(names[i][k] >= 65 && names[i][k] <= 90) && !(names[i][k] >= 97 && names[i][k] <= 122) && !(names[i][k] == 45 || names[i][k] == 95))
                    {
                        isValid = false;
                    }
                }
                if (isValid)
                {
                    validNames.Add(names[i]);
                }

            }

            Console.WriteLine(string.Join(Environment.NewLine, validNames));
        }
    }
}
