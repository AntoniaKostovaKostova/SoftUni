using System;
using System.IO;

namespace Ex07CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            bool isFinished = false;
            int tickets = 0;
            int student = 0;
            int standard = 0;
            int kid = 0;
            while (line != "Finish")
            {
                int i = 0;
                string name = "";
                int freespaces = 0;
                int movieTickets = 0;
                while (line != "End")
                {

                    if (i == 0)
                    {
                        name = line;
                    }
                    else if (i == 1)
                    {
                        freespaces = int.Parse(line);
                    }
                    else
                    {
                        string type = line;
                        if (type == "student")
                        {
                            movieTickets++;
                            tickets++;
                            student++;
                        }
                        if (type == "standard")
                        {
                            movieTickets++;
                            tickets++;
                            standard++;
                        }
                        if (type == "kid")
                        {
                            movieTickets++;
                            tickets++;
                            kid++;
                        }
                    }
                    if (movieTickets != 0 && movieTickets >= freespaces)
                    {
                        line = "End";
                    }
                    else
                    {
                        line = Console.ReadLine();
                        i++;
                    }

                    if (line == "Finish")
                    {
                        isFinished = true;
                        break;
                    }
                }
                double hallSpace = ((double)movieTickets / freespaces) * 100;
                Console.WriteLine($"{name} - {hallSpace:f2}% full.");
                if (!isFinished)
                {

                    line = Console.ReadLine();

                }
                if (line == "Finish")
                {
                    Console.WriteLine($"Total tickets: {tickets}");
                    Console.WriteLine($"{(double)student / tickets * 100:f2}% student tickets.");
                    Console.WriteLine($"{(double)standard / tickets * 100:f2}% standard tickets.");
                    Console.WriteLine($"{(double)kid / tickets * 100:f2}% kids tickets.");
                }

            }

        }
    }
}
