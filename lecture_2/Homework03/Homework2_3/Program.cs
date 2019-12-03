using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 0;
            do
            {
                Console.WriteLine("Введите число:");
                a = Convert.ToInt32(Console.ReadLine());
                if ((a > 0) && ((a % 2) == 1))
                {
                    b++;
                }
            } while (a != 0);
            Console.WriteLine($"число всех нечетных положительных чисел = {b}");
            Console.ReadKey();
        }
    }
}
