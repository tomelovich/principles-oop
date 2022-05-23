using System;

namespace Z_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите A и B:");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int kol = B - A + 1;
            if (A > B)
            {
                Console.WriteLine("A должно быть меньше или равным B");
            }
            for (int i = A; i <= B; i++)
                Console.WriteLine(i);
            Console.WriteLine("Кол-во чисел = {0}", kol);
            Console.ReadLine();
        }
    }
}
