using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static double distance(int xx1, int yy1, int xx2, int yy2)
        {
            return Math.Sqrt(Math.Pow(xx2 - xx1, 2) + Math.Pow(yy2 - yy1, 2));
        }


        static void Main(string[] args)
        {
            //ввод координаты A
            Console.WriteLine("enter the first coordinate A(x1,y1):");
            Console.Write("enter x:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter y:");
            int y1 = Convert.ToInt32(Console.ReadLine());

            //ввод координаты B
            Console.WriteLine("enter the second coordinate B(x2,y2):");
            Console.Write("enter x2:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter y2:");
            int y2 = Convert.ToInt32(Console.ReadLine());

            //расчет расстояния r между точками A и B
            //double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            
            //вывод расстояния r
            //Console.Write("the distance between A and B is:{0:0.##}",r);
            Console.Write("the distance between A and B is:{0:f2}", distance(x1, y1, x2, y2));
          
            Console.ReadKey();
        }
    }
}
