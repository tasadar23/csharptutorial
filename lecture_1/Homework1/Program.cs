using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //ввод имени
            Console.Write("Enter you name:");
            String name = Console.ReadLine();
            //ввод фамилии
            Console.Write("Enter you surname:");
            String surname = Console.ReadLine();
            //ввод возраста
            Console.Write("Enter you age:");
            String age = Console.ReadLine();
            //ввод роста
            Console.Write("Enter you height:");
            String height = Console.ReadLine();
            //ввод веса
            Console.Write("Enter you weight:");
            String weight = Console.ReadLine();
            //вывод информации методом склеивания
            Console.WriteLine("\nthe output of information by gluing: name- " + name + ", surname- " + surname + ", age- " + age + ", height- " + height + ", weight- " + weight + ";");
            //использование форматированного вывода
            Console.WriteLine("the use of formatted output:name- {0}, surname- {1}, age- {2}, height- {3}, weight- {4};",name,surname,age,height,weight);
            //используя вывод со знаком $
            Console.WriteLine($"using the conclusion with the sign $:name- {name}, surname- {surname}, age- {age}, height- {height}, weight- {weight};");
            Console.ReadKey();
        }
    }
}
