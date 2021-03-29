using System;

namespace Ex08LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string part = string.Empty;
            double number = 0;
            double result = 0;
            double finalNumber = 0;
            for (int i = 0; i < input.Length; i++)
            {
                part = input[i];
                number = double.Parse(part.Substring(1, part.Length - 2));
                result = GetResult(part, number);
                finalNumber += result;
            }

            Console.WriteLine($"{finalNumber:F2}");
        }

        private static double GetResult(string part, double number)
        {
            double result;
            if (Char.IsLower(part[0])) // first char
            {
                int firstChar = part[0] - 96;

                result = 1.0 * number * firstChar;
            }
            else
            {
                int firstChar = part[0] - 64;

                result = 1.0 * number / firstChar * 1.0;
            }

            if (Char.IsLower(part[part.Length - 1])) // last char
            {
                int lastChar = part[part.Length - 1] - 96;

                result = result + lastChar;
            }
            else
            {
                int lastChar = part[part.Length - 1] - 64;

                result = result - lastChar;
            }

            return result;
        }
    }
}
