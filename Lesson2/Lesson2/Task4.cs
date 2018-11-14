using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsefulThings;

//Илья Бугров

//4. Реализовать метод проверки логина и пароля. 
//На вход подается логин и пароль. 
//На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
//Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
//программа пропускает его дальше или не пропускает. С помощью цикла do while
//ограничить ввод пароля тремя попытками.

namespace Lesson2
{
    partial class Program
    {
        static bool Login(string log, string pas)
        {
            return log == "root" && pas == "GeekBrains";
        }

        static void Task4()
        {
            int tries = 3;
            string log, pas;
            do
            {
                Console.Write("Введите логин: ");
                log = Console.ReadLine();
                Console.Write("Введите пароль: ");
                pas = Console.ReadLine();
                if (Login(log,pas))
                {
                    Console.WriteLine("Вы успешно вошли в систему.");
                    Useful.Pause();
                    break;
                }
                else
                {
                    tries--;
                    Console.WriteLine("Вы указали неправильный логин, либо пароль. У вас осталось {0} попыток на авторизацию.", tries);
                    
                }
            }
            while (tries > 0);

            if (tries == 0)
            {
                Console.WriteLine();
                Console.WriteLine("У вас не осталось попыток на авторизацию, доступ закрыт.");
                Useful.Pause();
            }
        }
    }
}
