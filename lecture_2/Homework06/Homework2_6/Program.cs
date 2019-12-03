using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Прошрамма подсчета хороших чисел в диапазоне от 1 до 1 000 000 000");
            int sum;
            int j;
            DateTime start = DateTime.Now;

            for (int i = 1; i <= 1000000000; i++)
            {
                j = i;
                sum = 0;
                while (j > 10)
                {
                    sum = sum + j % 10;
                    j = (j - j % 10) / 10;

                }
                sum = sum + j;
                if ((i % sum) == 0) Console.Write($"{i},");
            }
            DateTime finish = DateTime.Now;
            Console.WriteLine($"\nвремя выполнения вычислений:{ finish - start}");
            Console.ReadKey();

        }
    }
}
