using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для входа в систему необходимо авторизоваться.\n Пожалуйста введите логин и пароль.");
            int i = 1;
            do
            {
                Console.Write("Введите логин:");
                string log = Console.ReadLine();
                Console.Write("Введите пароль:");
                string pas = Console.ReadLine();
                bool resp = verif(log, pas);
                if (resp == true)
                {
                    Console.WriteLine("Поздравляю! Вы прошли авторизацию!!!");
                    break;
                }
                else Console.WriteLine($"Попробуйте еще раз, осталось попыток {3 - i}");
                i++;
            } while (i <= 3);
            Console.ReadKey();
        }
        static bool verif(string login, string password)
        {
            if ((login == "root") && (password == "GeekBrains")) return true;
            else return false;
        }
    }
}
