using System;

namespace Ex08OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examTimeHour = int.Parse(Console.ReadLine());
            int examTimeMinute = int.Parse(Console.ReadLine());
            int examTimeHourArrival = int.Parse(Console.ReadLine());
            int examTimeMinuteArrival = int.Parse(Console.ReadLine());

            int examTimeInMinutes = examTimeHour * 60 + examTimeMinute;
            int examTimeInMinutesArrival = examTimeHourArrival * 60 + examTimeMinuteArrival;
            if (examTimeInMinutesArrival > examTimeInMinutes)
            {
                Console.WriteLine("Late");
            }
            else if (examTimeInMinutesArrival == examTimeInMinutes || examTimeInMinutesArrival >= examTimeInMinutes - 30)
            {
                Console.WriteLine("On time");
            }
            else if (examTimeInMinutesArrival <= examTimeInMinutes - 30)
            {
                Console.WriteLine("Early");
            }
            if (examTimeInMinutes != examTimeInMinutesArrival)
            {               
                if ((examTimeInMinutes - examTimeInMinutesArrival > 0) && (examTimeInMinutes - examTimeInMinutesArrival) < 60)
                {
                    Console.WriteLine($"{(examTimeInMinutes - examTimeInMinutesArrival) % 60} minutes before the start");
                }
                else if ((examTimeInMinutes - examTimeInMinutesArrival > 0) && (examTimeInMinutes - examTimeInMinutesArrival) >= 60)
                {
                    Console.WriteLine($"{(examTimeInMinutes - examTimeInMinutesArrival) / 60}:{((examTimeInMinutes - examTimeInMinutesArrival) % 60).ToString("D2")} hours before the start");
                }
                else if ((examTimeInMinutesArrival - examTimeInMinutes) < 60)
                {
                    Console.WriteLine($"{((examTimeInMinutesArrival - examTimeInMinutes) % 60)} minutes after the start");
                }
                else if ((examTimeInMinutesArrival - examTimeInMinutes) >= 60)
                {
                    Console.WriteLine($"{(examTimeInMinutesArrival - examTimeInMinutes) / 60}:{((examTimeInMinutesArrival - examTimeInMinutes) % 60).ToString("D2")} hours after the start");
                }
            }
        }
    }
}
