using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a program for exchanging the values of two variables");
            Console.WriteLine("using the third variable");
            Console.Write("enter the first variable (a1):");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the second variable (b1):");
            int b1 = Convert.ToInt32(Console.ReadLine());
            //с использованием третей переменной
            int c = a1;
            a1 = b1;
            b1 = c;
            Console.WriteLine("output variables after conversion: a1 = {0}, b1 = {1}", a1, b1);
            //без использования третей переменной
            Console.WriteLine("without using the third variable");
            Console.Write("enter the first variable (a2):");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the second variable (b2):");
            int b2 = Convert.ToInt32(Console.ReadLine());
            b2 = a2 + b2;
            a2 = b2 - a2;
            b2 = b2 - a2;
            Console.Write("output variables after conversion: a2 = {0}, b2 = {1}", a2, b2);
            Console.ReadKey();
        }
    }
}
