using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, z;
            int c;
            Console.Write("Введите сумму ежемесячного вклада: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите процентную ставку: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во лет: ");
            c = Convert.ToInt32(Console.ReadLine());
            a *= 12;
            z = a;
            for (int i = 1; i <= c; i++)
            {
                Console.WriteLine("В " + i + " год: ");
                Console.WriteLine("Заработок за год - " + Math.Round(a * (b / 100), 0) + " руб");
                a = a + (a * (b / 100));
                Console.WriteLine("Портфель - " + Math.Round(a, 2) + " руб");
                Console.WriteLine();
                a += z;

            }
            Console.ReadKey();

        }
    }
}
