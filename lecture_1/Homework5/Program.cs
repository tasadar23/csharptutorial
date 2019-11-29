using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {

        static void Print(String message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.SetWindowSize(120, 30);
            Console.SetCursorPosition(45, 15);
            String text = "Юлдашев Азат город Губкинский";
            Print(text);
        }
    }
}
