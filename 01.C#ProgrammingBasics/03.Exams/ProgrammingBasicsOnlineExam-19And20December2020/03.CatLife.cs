using System;

namespace Ex03CatLife
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            char gender = char.Parse(Console.ReadLine());
            double years = 0;
            bool isValid = true;
            switch (type)
            {
                case ("British Shorthair"):
                    if (gender == 'm')
                    {
                        years = 13;
                    }
                    else if (gender == 'f')
                    {
                        years = 14;
                    }
                    break;
                case ("Siamese"):
                    if (gender == 'm')
                    {
                        years = 15;
                    }
                    else if (gender == 'f')
                    {
                        years = 16;
                    }
                    break;
                case ("Persian"):
                    if (gender == 'm')
                    {
                        years = 14;
                    }
                    else if (gender == 'f')
                    {
                        years = 15;
                    }
                    break;
                case ("Ragdoll"):
                    if (gender == 'm')
                    {
                        years = 16;
                    }
                    else if (gender == 'f')
                    {
                        years = 17;
                    }
                    break;
                case ("American Shorthair"):
                    if (gender == 'm')
                    {
                        years = 12;
                    }
                    else if (gender == 'f')
                    {
                        years = 13;
                    }
                    break;
                case ("Siberian"):
                    if (gender == 'm')
                    {
                        years = 11;
                    }
                    else if (gender == 'f')
                    {
                        years = 12;
                    }
                    break;
                default:
                    Console.WriteLine($"{type} is invalid cat!");
                    isValid = false;
                    break;
            }
            double months = Math.Floor(years * 2);
            if (isValid)
            {
                Console.WriteLine($"{months} cat months");
            }
        }
    }
}
