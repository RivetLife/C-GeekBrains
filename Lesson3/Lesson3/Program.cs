using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Илья Бугров
// Меню программы

namespace Lesson3
{
    partial class Program
    {

        static void Menu()
        {
            Console.Write("Введите номер задания: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Task1();
                    break;

                case "2":
                    Task2();
                    break;

                case "3":
                    Task3();
                    break;

                case "4":
                    Task4();
                    break;

                default:
                    Console.WriteLine("Введен неправильный вариант ответа. Программа завершает работу.");
                    break;
            }

            
        }

        static void Main()
        {
            Menu();   
        }
    }
}
