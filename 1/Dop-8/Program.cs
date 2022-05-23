using System;

namespace Dop_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Введите число");
            int ch = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= ch; i++)
                if (ch % i == 0)
                {
                    count++;
                }
            Console.WriteLine("Кол-во делителей - {0}", count);
        }
    }
}
