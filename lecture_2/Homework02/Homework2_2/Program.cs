using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            int numofdigits = digits(a);
            Console.WriteLine($"количество цифр числа = {numofdigits}");
            Console.ReadKey();
        }
        static int digits(int aa)
        {
            int i = 1;
            while (aa >= 10)
            {
                aa = aa / 10;
                i++;
            }
            return i;
        }
    }
}
