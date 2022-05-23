using System;

namespace Dop_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int rez = 0;
            Console.WriteLine("Введите цифру k");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число n");
            string n = Console.ReadLine();
            for (int i = 1; i < n.Length; i++)
            {
                if (k == int.Parse(n[i].ToString()))
                    rez = rez + 1;
            }
            Console.WriteLine(rez);
        }
    }
}
