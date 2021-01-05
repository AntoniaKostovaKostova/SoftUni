using Microsoft.VisualBasic;
using System;
using System.Runtime.Serialization;

namespace Ex04PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
        
            string result = "";

            if (age >= 16)
            {
                if (gender == "f")
                {
                    result = "Ms.";
                }
                else if (gender == "m")
                {
                    result = "Mr.";
                }               
            }
            else if (age < 16)
            {
                if (gender == "f")
                {
                    result = "Miss";
                }
                else if (gender == "m")
                {
                    result = "Master";
                }
            }
            Console.WriteLine(result);
        }
    }
}
