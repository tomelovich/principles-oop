using System;

namespace Dop_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i < 99; i++)
            {
                int c1 = i / 10;
                int c2 = i % 10;
                if ((c1 * c1 + c2 * c2) % 13 == 0)
                    Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
