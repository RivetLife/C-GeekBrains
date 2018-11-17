using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Илья Бугров
//Меню

namespace Lesson4
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
                default:
                    Console.WriteLine("Введен неверный номер задания.");
                    break;
            }
        }

        static void Main()
        {
            Menu();
        }
    }
}
