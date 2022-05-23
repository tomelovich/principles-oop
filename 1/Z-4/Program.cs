using System;

namespace Z_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите A и B:");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            if (A > B)
            {
                Console.WriteLine("A должно быть меньше или равным B");
            }
            for (int i = B; i >= A; i--)
            {
                Console.WriteLine(Math.Pow(i, 3));
            }
            Console.WriteLine("----------");
            while (B >= A)
            {
                Console.WriteLine(Math.Pow(B, 3));
                B--;
            }
        }
    }
}
