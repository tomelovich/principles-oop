using System;

namespace Z_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x:");
            double x = Convert.ToInt32(Console.ReadLine());
            double y;
            if ((x>3) && (x < 7))
            {
                y = x;
                Console.WriteLine("y = {0}", y);
            }
            else if (x > 6)
            {
                y = 3 * x + 4 * (Math.Pow(x,2));
                Console.WriteLine("y = {0}", y);
            }
            else
            {
                Console.WriteLine("Значение х не соответствует условию");
            }
        }
    }
}
