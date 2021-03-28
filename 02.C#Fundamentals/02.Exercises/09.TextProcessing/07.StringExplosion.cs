using System;
using System.Text;

namespace Ex07StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int reminder = 0;

            for (int i = 0; i < line.Length; i++)
            {
                char character = line[i];
                if (character == '>')
                {
                    int strength = int.Parse(line[i + 1].ToString());
                    reminder += strength;

                    while (reminder > 0)
                    {
                        if (line.Length > i + 1 && line[i + 1] != '>')
                        {
                            line = line.Remove(i + 1, 1);
                            reminder -= 1;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(line);
        }
    }
}
