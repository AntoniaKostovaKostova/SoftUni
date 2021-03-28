using System;
using System.Text;

namespace Ex06ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder newSequense = new StringBuilder();
            char previous = ' ';

            foreach (char letter in text)
            {
                if (!letter.Equals(previous))
                {
                    newSequense.Append(letter);
                }
                previous = letter;
            }
            Console.WriteLine(newSequense);
        }
    }
}
