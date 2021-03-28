using System;

namespace Ex03ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string nameWithExtension = input.Substring(input.LastIndexOf('\\')+1);

            string fileName = nameWithExtension.Substring(0, nameWithExtension.LastIndexOf('.'));
            string extension = nameWithExtension.Substring(nameWithExtension.LastIndexOf('.') + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
