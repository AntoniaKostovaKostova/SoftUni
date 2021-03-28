using System;
using System.Text;

namespace Ex04CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder output = new StringBuilder();

            foreach (char letter in input)
            {
                output.Append((char)(letter + 3));
            }

            Console.WriteLine(output);
        }
    }
}
