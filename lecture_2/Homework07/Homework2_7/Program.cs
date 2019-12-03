using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"числа входящие в диапазон от {a} до {b}: ");

            output_text(a, b);
            //for (int i = a; i < b; i++)
            //{
            //    Console.Write($"{i}, ");                            
            //}
            //int j=0;
            //for (int i = a; i < b; i++)
            //{
            //    j = j + i;
            //}
            //Console.WriteLine($"\nсумма чисел в диапазоне = {j}");
            //Console.ReadKey();
        }

        static void output_text(int aa, int bb)
        {
            for (int i = aa; i < bb; i++)
            {
                Console.Write($"{i}, ");
            }
            int j = 0;
            for (int i = aa; i < bb; i++)
            {
                j = j + i;
            }
            Console.WriteLine($"\nсумма чисел в диапазоне = {j}");
            Console.ReadKey();

        }
    }
}
