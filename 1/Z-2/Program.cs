using System;

namespace Z_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int one, two, three;
            Console.WriteLine("Введите трёхзначное число:");
            string chislo = (Console.ReadLine());
            if ((chislo.Length < 4) && (chislo.Length > 2))
            {
                one = Int32.Parse(chislo[0].ToString());
                two = Int32.Parse(chislo[1].ToString());
                three = Int32.Parse(chislo[2].ToString());
                if((one == two) && (one ==three))
                {
                    Console.WriteLine("Цифры числа {0} одинаковы",chislo);
                }
                else
                {
                    Console.WriteLine("Цифры числа {0} не одинаковы", chislo);
                }
                Console.ReadLine();
            }
        }
    }
}
