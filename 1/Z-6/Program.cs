using System;

namespace Z_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = 0.5;
            double M = 10;
            double B = 1;
            double H = (B - A)/M;
            Console.WriteLine("Значения функции arccos(x):");
            for (double i = A; i <= B; i += H)
            {
                Console.WriteLine(Math.Acos(i));
            }
            Console.ReadLine();
        }
    }
}
