using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//Илья Бугров
//1. Создать программу, которая будет проверять корректность ввода логина. 
//Корректным логином будет строка от 2 до 10 символов, содержащая только буквы
//латинского алфавита или цифры, при этом цифра не может быть первой:
//а) без использования регулярных выражений;
//б) ** с использованием регулярных выражений.

namespace Lesson5
{
    partial class Program
    {
        static bool LetterCheck(char letter)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            bool check = false;
                for (int j = 0; j < 26; j++)
                {
                if (letter == alphabet[j] || letter == char.ToUpper(alphabet[j]))
                    {
                    check = true;
                    }
                }

            return check;

        }

        static bool TrueLogin(string login)
        {
            if (login.Length < 2 || login.Length > 10)
            {
                return false;
            }

            {
                if (char.IsDigit(login[0]))
                {
                    return false;
                }
                else
                {
                    for (int i = 0; i < login.Length; i++)
                    {
                        if (!LetterCheck(login[i]) && !char.IsDigit(login[i]))
                        {
                            return false;
                        }
                    }
                }
             return true;
            }
        }

        static void Task1()
        {
            Console.Write("Введите логин: ");
            string login = Console.ReadLine();

            // A

            if (TrueLogin(login))
            {
                Console.WriteLine("Введённый логин верен, авторизация успешно завершена");
            }
            else
            {
                Console.WriteLine("Введён не верный логин.");
            }

            // B

            Console.WriteLine("Проверка через регулярные выражения.");

            Regex check = new Regex(@"^[A-Za-z]{1}[0-9A-Za-z]{1,9}$");
            if (check.IsMatch(login))
            {
                Console.WriteLine("Введённый логин верен, авторизация успешно завершена");
            }
            else
            {
                Console.WriteLine("Введён не верный логин.");
            }

            Console.ReadKey();
        }

    }
}
