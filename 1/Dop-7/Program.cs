using System;

namespace Dop_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число");
            string ch = Console.ReadLine();
            if (int.Parse(ch[0].ToString()) > int.Parse(ch[1].ToString()) && (int.Parse(ch[1].ToString()) > int.Parse(ch[2].ToString())))
            {
                Console.WriteLine("Цифры упорядочены");
            }
            else
            {
                Console.WriteLine("Цифры не упорядочены");
            }
        }
    }
}
