using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для расчета инекса веса");
            Console.Write("Ввдите массу тела (кг):");
            double ves = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ввдите рост тела (м):");
            double rost = Convert.ToDouble(Console.ReadLine());
            double ind = ves / (rost * rost);
            double dev;
            if (ind < 18.5)
            {
                dev = (18.5 * rost * rost) - ves;
                Console.Write("Вам необходимо поправится на: ");
                Console.Write("{0:0.##}", dev);
                Console.WriteLine(" кг");
            }
            else if (ind > 25)
            {
                dev = ves - (25 * rost * rost);
                Console.Write($"Вам необходимо похудеть на: ");
                Console.Write("{0:0.##}", dev);
                Console.WriteLine(" кг");
            }
            else Console.WriteLine("Вы в отличной форме.");

            Console.ReadKey();

        }
    }
}
