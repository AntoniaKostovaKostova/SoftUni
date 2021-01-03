using System;

namespace Ex04MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string inputMeasure = Console.ReadLine();
            string outputMeasure = Console.ReadLine();
            double result = 0; 
            if(inputMeasure==outputMeasure)
            {
                result = number;               
            }
            else
            {
                if (inputMeasure == "m" && outputMeasure == "cm")
                {
                    result = number * 100;
                }
                if (inputMeasure == "m" && outputMeasure == "mm")
                {
                    result = number * 1000;
                }
                if (inputMeasure == "cm" && outputMeasure == "m")
                {
                    result = number / 100;
                }
                if (inputMeasure == "cm" && outputMeasure == "mm")
                {
                    result = number * 10;
                }
                if (inputMeasure == "mm" && outputMeasure == "cm")
                {
                    result = number / 10;
                }
                if (inputMeasure == "mm" && outputMeasure == "m")
                {
                    result = number / 1000;
                }
            }
            
            Console.WriteLine($"{result:F3}");
        }
    }
}
