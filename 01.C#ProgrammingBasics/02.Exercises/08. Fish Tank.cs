using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double V = a * b * h; // obem v KUBI4NI sm           
            double takenV = (V * percent * 0.01); // taken space in KUBIC sm
            double freeV = V - takenV; 
            double liters = freeV*0.001; // cubic sm*0.001 = 1 liter
            Console.WriteLine(liters);
        }
    }
}
