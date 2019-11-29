using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6_lib
{
    public class Class1
    {
        //метод Print
        static public void Print(String message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }

        //метод distance
        static public double distance(int xx1, int yy1, int xx2, int yy2)
        {
            return Math.Sqrt(Math.Pow(xx2 - xx1, 2) + Math.Pow(yy2 - yy1, 2));
        }
    }

}
