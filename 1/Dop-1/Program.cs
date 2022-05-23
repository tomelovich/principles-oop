using System;

namespace Dop_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку:");
            string str = Console.ReadLine();
            int max = int.Parse(str[0].ToString());
            int min = int.Parse(str[0].ToString());
            for (int i = 1; i < str.Length; i++)
            {
                if (max < int.Parse(str[i].ToString()))
                    max = int.Parse(str[i].ToString());
                if (min > int.Parse(str[i].ToString()))
                    min = int.Parse(str[i].ToString());
            }
            Console.WriteLine("Наибольшая цифра = {0}, Наименьшая = {1} ", max, min);
            Console.ReadLine();
        }
    }
}
