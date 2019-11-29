using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ввод веса
            Console.Write("Enter you weight(m):");
            float m = Convert.ToInt32(Console.ReadLine());

            //ввод роста
            Console.Write("Enter you height(h):");
            float h = Convert.ToInt32(Console.ReadLine());

            //расчет индекса массы тела(ИМТ)
            float i = m / (h * h);
            Console.WriteLine("Body mass index is calculated by the formula: i = m / (h * h);");  
            Console.Write("\nBody mass index i is equal to:" + i +" (кг/м^2);");
            Console.ReadKey();
            
        }
    }
}
