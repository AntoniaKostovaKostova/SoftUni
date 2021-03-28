using System;
using System.Collections.Generic;
using System.Text;

namespace Ex05MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine().TrimStart(new char[] { '0' });
            int multiplier = int.Parse(Console.ReadLine());

            int reminder = 0;

            List<string> result = new List<string>();

            for (int i = number.Length - 1; i >= 0; i--)
            {
                if (multiplier == 0)
                {
                    result.Add("0");
                    break;
                }

                int digit = number[i] - '0';

                reminder += multiplier * digit;

                if (reminder > 9)
                {
                    int remainderLastDigit = reminder % 10;

                    reminder /= 10;

                    result.Add(remainderLastDigit.ToString());
                }
                else
                {
                    result.Add(reminder.ToString());
                    reminder = 0;
                }
            }
            if (reminder > 0)
            {
                result.Add(reminder.ToString());
            }
            result.Reverse();

            Console.WriteLine(string.Concat(result));
        }
    }
}
