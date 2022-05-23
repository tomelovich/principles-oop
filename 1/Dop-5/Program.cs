using System;

namespace Dop_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; ; i++)
            {
                if (n % 2 == 0)
                {
                    n = n / 2;
                }
                else if (n % 2 == 1)
                {
                    n = 3 * n + 1;
                }
                if (n == 1)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
