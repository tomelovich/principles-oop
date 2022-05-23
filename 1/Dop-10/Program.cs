using System;

namespace Dop_10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i < 99; i++)
                if (3 * (i % 10) * (i / 10) == i)
                {
                    Console.WriteLine(i);
                }
            Console.ReadLine();
        }
    }
}
