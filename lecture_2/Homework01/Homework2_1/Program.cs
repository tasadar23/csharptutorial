using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            int c = Convert.ToInt32(Console.ReadLine());

            int min = min_value(a, b, c);
            Console.WriteLine($"минимальное значение: {min}");
            Console.ReadKey();

        }
        static int min_value(int aa, int bb, int cc)
        {
            if (aa > bb && aa > cc) return aa;
            else if (bb > cc) return bb;
            else return cc;
        }
    }
}
