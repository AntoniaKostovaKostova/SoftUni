using System;

namespace Ex9Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string leapOrNormal = Console.ReadLine();
            int p = int.Parse(Console.ReadLine()); //holiday days
            int h = int.Parse(Console.ReadLine()); // weekends in own town
            double weekendsForVolleyBall = 48;
            double daysForVolleyball = 48 * 2;
            double daysToPlayPerYear = 0.0;

            //играе в София всяка събота, когато не е на работа и не си пътува до родния град, 
            //както и в 2 / 3 от празничните дни. 
            double footballInHolidays = ((double)2 / (double)3) * p;
            //Той пътува до родния си град h пъти в годината, където играе волейбол със старите си
            //приятели в неделя.
            double weekendsInHomeTown = h;
            //Влади не е на работа 3 / 4 от уикендите, в които е в София. 
            double weekendsInSofia = weekendsForVolleyBall - h;
            double freeWeekendsInSofia = ((double)3 / (double)4) * weekendsInSofia;
            //Отделно, през високосните години Влади играе с 15 % повече волейбол от нормалното.

            daysToPlayPerYear = weekendsInHomeTown + freeWeekendsInSofia + footballInHolidays;

            if (leapOrNormal == "normal")
            {
                Console.WriteLine(Math.Floor(daysToPlayPerYear));
            }
            else if (leapOrNormal == "leap")
            {
                Console.WriteLine(Math.Floor((daysToPlayPerYear)+ daysToPlayPerYear*0.15));
            }
        }
    }
}
