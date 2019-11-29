using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Homework6_lib.Class1;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(120, 30);
            Console.SetCursorPosition(45, 15);
            String text = "Юлдашев Азат город Губкинский";

            //использование бибилиотеки Homework6_lib
            Print(text);
        }
    }
}
